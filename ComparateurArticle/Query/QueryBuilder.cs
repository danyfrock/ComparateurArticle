namespace ComparateurArticle.Query
{
    internal class QueryBuilder
    {
        private string four;

        public QueryBuilder(string four)
        {
            this.four = four;
        }

        public string GetQuerySociete(IEnumerable<IEnumerable<string>> excelValuesListe) =>
            QuerySociete(four, ValueTableBuilder.BuildValuesTableForCTE(excelValuesListe))
            ;
        public string GetQueryGroupe(IEnumerable<IEnumerable<string>> excelValuesListe) =>
            QueryGroupe(four, ValueTableBuilder.BuildValuesTableForCTE(excelValuesListe))
            ;

        public string GetQueryFour(IEnumerable<IEnumerable<string>> excelValuesListe) =>
            QueryFour(ValueTableBuilder.BuildValuesTableForCTE(excelValuesListe))
            ;

        private string QueryGroupe(string four, string valuesTable) => $@"
with
 params as (
    select '{four}' as idfour from SYSIBM.sysdummy1 -- 01P1 -- VA119 --BA220--AT051
)
,produits AS (
    SELECT t.col1 AS ref, t.col2 AS gencode 
    FROM 
        {valuesTable}
)
, restrictARTGROU as (
select distinct
    --DENSE_RANK() OVER(PARTITION BY ARTGROU.AGREFG ORDER BY ARTGROU.AGDMAJ DESC) as rang,
    ARTGROU.*
from
    COMAGR_FIC.ARTGROU ARTGROU
    inner join params on ARTGROU.AGFOUR = params.idfour
    --/*
    inner join produits on (produits.ref <> '' and ARTGROU.AGREFO = produits.ref) 
                            or (produits.gencode <> '' and ARTGROU.AGREFG = produits.gencode)
    --*/
)
, rankedtargrou as (
     select 
            dense_rank() over(partition by TGREFO,TGFOUR order by TGDMAJ desc) as rang,
            SUBSTR(TARGROU.TGDATE, 7, 2) || '/' || SUBSTR(TARGROU.TGDATE, 5, 2) || '/' || SUBSTR(TARGROU.TGDATE, 1, 4) AS TGDATEformat,
            TARGROU.*
      from 
            COMAGR_FIC.TARGROU TARGROU
            inner join restrictARTGROU ARTGROU on TARGROU.TGREFO = ARTGROU.AGREFO
                                                  and TARGROU.TGFOUR = ARTGROU.AGFour
       where
            TARGROU.TGQTUC = '0'
 )
 , toptargrou as ( select * from rankedtargrou where rang = 1)
, rankedremfou as(
    select 
        dense_rank() over(partition by REMFGROU.RFGTAC,REMFGROU.RFFOUR order by RFDATE desc) as rang,
        REMFGROU.*
    from
        COMAGR_FIC.REMFGROU REMFGROU
     where
        REMFGROU.RFDFIN = '99999999'
  )
  , topremfou as ( select distinct * from rankedremfou where rang = 1)
  , rankedFGtargrou as (
    select 
        dense_rank() over(partition by FGTAGROU.FGGTAC,FGTAGROU.FGFOUR order by FGDMAJ desc) as rang,
        FGTAGROU.*
    from
         COMAGR_FIC.FGTAGROU FGTAGROU
         inner join restrictARTGROU ARTGROU on FGTAGROU.FGFOUR = ARTGROU.AGFour
                                               and FGTAGROU.FGGTAC = ARTGROU.AGGTAC
     where
         FGTAGROU.FGDFIN = '99991231'
  ) 
  , topFGtargrou as (select distinct * from rankedFGtargrou where rang = 1)
  , donneesgroupe as (
 select
    
ARTGROU.AGDESI, ARTGROU.AGDCRS, ARTGROU.AGDCRE, ARTGROU.AGDMAS, ARTGROU.AGDMAJ, -- Indices 0-4
ARTGROU.AGUSER, ARTGROU.AGSUPP, ARTGROU.AGDSUS, ARTGROU.AGDSUP, ARTGROU.AGFOUR, -- Indices 5-9
ARTGROU.AGREFO, ARTGROU.AGRFO2, ARTGROU.AGREFG, ARTGROU.AGRFG2, ARTGROU.AGUACH, -- Indices 10-14
ARTGROU.AGUCDE, ARTGROU.AGMACH, ARTGROU.AGSACH, ARTGROU.AGUCOV, ARTGROU.AGUCON, -- Indices 15-19
ARTGROU.AGDELA, ARTGROU.AGCACH, ARTGROU.AGQPAL, ARTGROU.AGGTAC, ARTGROU.AGRFCO, -- Indices 20-24
ARTGROU.AGVOLU, ARTGROU.AGLONG, ARTGROU.AGLARG, ARTGROU.AGHAUT, ARTGROU.AGDIAM, -- Indices 25-29
ARTGROU.AGPDS, ARTGROU.AGGPDS, ARTGROU.AGTVA, ARTGROU.AGSERV, ARTGROU.AGCHAP, -- Indices 30-34
ARTGROU.AGSSCH, ARTGROU.AGCHRO, ARTGROU.AGORDS, ARTGROU.AGORDR, ARTGROU.AGDETC, -- Indices 35-39
ARTGROU.AGFRNG, ARTGROU.AGCACI, ARTGROU.AGQCAM, ARTGROU.AGTPFX, ARTGROU.AGNBTP, -- Indices 40-44
ARTGROU.AGTPF2, ARTGROU.AGNBT2, ARTGROU.AGTPF3, ARTGROU.AGNBT3, ARTGROU.AGTPF4, -- Indices 45-49
ARTGROU.AGNBT4, ARTGROU.AGPDSE, ARTGROU.AGARGU, ARTGROU.AGMATR, ARTGROU.AGBAIN, -- Indices 50-54
ARTGROU.AGLVAR, ARTGROU.AGCPRO, ARTGROU.AGGRST, ARTGROU.AGDISP, ARTGROU.AGTYPF, -- Indices 55-59
ARTGROU.AGUNIF, ARTGROU.AGFCAC, ARTGROU.AGMARQ, ARTGROU.AGGAMM, ARTGROU.AGCINF, -- Indices 60-64
ARTGROU.AGQMIN, ARTGROU.AGTMIN, ARTGROU.AGSTKF, ARTGROU.AGEDI, ARTGROU.AGNBGA, -- Indices 65-69
ARTGROU.AGSTAR, ARTGROU.AGSTAD, ARTGROU.AGRECR, ARTGROU.AGRECD, ARTGROU.AGRECO, -- Indices 70-74
ARTGROU.AGREMP, ARTGROU.AGCEE, ARTGROU.AGROHS, ARTGROU.AGGTA2, ARTGROU.AGGTA3, -- Indices 75-79
ARTGROU.AGDLST, ARTGROU.AGCGRGRO, ARTGROU.AGCGRFAM, ARTGROU.AGCGRSFA, ARTGROU.AGCGRSSF, -- Indices 80-84
ARTGROU.AGDEMCLA, ARTGROU.AGPCGGRO, ARTGROU.AGPCGFAM, ARTGROU.AGPCGSFA, ARTGROU.AGPCGSSF, -- Indices 85-89
ARTGROU.AGCHRONO, ARTGROU.AGCODMARQ, ARTGROU.AGUQI, ARTGROU.AGMUQI, ARTGROU.AGSUQI, -- Indices 90-94
ARTGROU.AGRFGEN, ARTGROU.AGRFORI, ARTGROU.AGMARKE1, ARTGROU.AGMARKE2, ARTGROU.AGMARKE3, -- Indices 95-99
ARTGROU.AGMARKE4, ARTGROU.AGMARKE5, -- Indices 100-101

    max(TARGROU.TGPTAR, TARGROU.TGPACH) as prix,--102
    FGTAGROU.FGDESI,--103
    REMFGROU.RFOPE1, REMFGROU.RFREM1, REMFGROU.RFOPE2,--104-105-106
    REMFGROU.RFREM2, REMFGROU.RFOPE3, REMFGROU.RFREM3,--107-108-109
    REMFGROU.RFOPE4, REMFGROU.RFREM4, REMFGROU.RFOPE5,--110-111-112
    REMFGROU.RFREM5, TARGROU.TGDATEformat, TARGROU.TGPCAT--113-115
    
    --,ARTGROU.rang
from
    restrictARTGROU ARTGROU
    inner JOIN toptargrou TARGROU on TARGROU.TGREFO = ARTGROU.AGREFO
                                                and TARGROU.TGFOUR = ARTGROU.AGFour
    left outer join topFGtargrou FGTAGROU on FGTAGROU.FGFOUR = ARTGROU.AGFour
                                               and FGTAGROU.FGGTAC = ARTGROU.AGGTAC
                                               and FGTAGROU.FGDFIN = '99991231'
    left outer join topremfou REMFGROU on REMFGROU.RFFOUR = ARTGROU.AGFOUR
                                                and REMFGROU.RFGTAC = ARTGROU.AGGTAC
)
select * from donneesgroupe
";
        private string QuerySociete(string four, string valuesTable) => $@"
with
params as (
    select '{four}' as idfour from SYSIBM.sysdummy1
)
,produits AS (
    SELECT t.col1 AS ref, t.col2 AS gencode 
    FROM 
        {valuesTable}
)
, calcDates as (
select
    current_date as current_date,
    add_days(current_date, -1* day(current_date)) as limitTo_date,
    add_years(add_days(current_date, -1* day(current_date) + 1),-1) as limitFrom_Date
from
    SYSIBM.SYSDUMMY1
)
,calcstatvenedate as (
select
    STATVENE.STMHT as STMHT, STATVENE.STQUAN as STQUAN,
    STATVENE.STNART as STNART, STATVENE.STNFOU as STNFOU,
    to_date('20' || STATVENE.STDFAA || '-' || lpad(STATVENE.STDFMM, 2, '0') || '-01', 'yyyy-MM-dd') as STDATE
from
    COMAFBCO.STATVENE STATVENE
    inner join params on STATVENE.STNFOU = params.idfour
where
    STTYCL in ('T','C','E')
    and STMHT <> 0
    and STQUAN <> 0
)
,restricStatveneDate as (
select
    STATVENE.STMHT, STATVENE.STQUAN,
    STATVENE.STNART, STATVENE.STNFOU
from
    calcstatvenedate STATVENE
    inner join calcDates c on 1=1
where
    STATVENE.STDATE between c.limitFrom_date and c.limitTo_date
)
,statveneCA as (
select
    STNART, STNFOU,
    Sum(STMHT) as CA, sum(STQUAN) as nb
from
    restricStatveneDate
group by
    STNART, STNFOU
)
, topprix as (
select
    DENSE_RANK() OVER (PARTITION BY prix.APCODF, prix.APFOUR ORDER BY prix.APDATE DESC) AS rang,
    prix.*
from
    COMAFICO.ARTIC ARTIC
	INNER JOIN COMAFICO.ARFOPRIX prix ON prix.APCODF = ARTIC.ARCODF
    inner join params p on prix.APFOUR = p.idfour
where
    APQTUC = '0.000'
    and APDEPO = ''
)
, prepareprix AS (
    SELECT
        DENSE_RANK() OVER (PARTITION BY prix.APCODF, prix.APFOUR ORDER BY prix.APDATE DESC) AS rang,
        prix.*
    FROM
        COMAFICO.ARFOPRIX prix
        inner join params p on prix.APFOUR = p.idfour
    WHERE
        prix.APQTUC = '0.000'
        and prix.APDEPO <> ''
        and prix.APDFIN = '99999999'
)
, concatprix AS (
    SELECT 
        prepareprix.APCODF,
        LISTAGG(APDEPO, '|') WITHIN GROUP (ORDER BY APDEPO) AS APDEPO_concatenated
    FROM 
        prepareprix
    WHERE 
        rang = 1
    GROUP BY 
        prepareprix.APCODF
)
, artic2 as (
select
    CONCAT(ARTIC.ARCODS,ARTIC.ARCODF) as codeArticle
    , artic.*
from
    COMAFICO.ARTIC ARTIC
)
,gta as (
select
    dense_rank() over(partition by FGFOUR, FGGTAC, FGSERV order by FGDMAJ desc) as rang,
    FRNGTA.*
from
     COMAFICO.FRNGTA FRNGTA
    inner join params p on FRNGTA.FGFOUR = p.idfour
)
,preselectremfo as (
 select
    *
from
    COMAFICO.REMFO REMFO 
where 
    rfdfin = '99999999'
)
, rankedremfo as (
select
    DENSE_RANK() OVER (PARTITION BY REMFO.RFGTAC, remfo.rffour, remfo.rfdfin ORDER BY REMFO.RFDATE DESC) AS rang
    , remfo.*
from preselectremfo remfo
)
, topremfo as (
select * from rankedremfo where rang = 1
)
, rankedStock as (
select
    DENSE_RANK() OVER (PARTITION BY w.ARFOUR, w.ESARTI, w.WDDEPO ORDER BY w.WDDACH DESC) AS rangDepot,
    DENSE_RANK() OVER (PARTITION BY w.ARFOUR, w.ESARTI ORDER BY w.WDDACH DESC) AS rangAchat,
    DENSE_RANK() OVER (PARTITION BY w.ARFOUR, w.ESARTI ORDER BY w.WDDAHC DESC) AS rang,
    w.*
from
    SAPVIEW.WANSTOVW w
    inner join params p on w.ARFOUR = p.idfour
where
    WDSDEP = '*'
)
, calcDernierAchat as (select distinct w.ARFOUR, w.ESARTI, w.WDDACH from rankedStock w where rangAchat = 1)
, calcStockSum as (
select
     w.ARFOUR, w.ESARTI
     , max(w.WDPF) as maxWdpf
    , sum(w.WDQTST) as QteStock
from
    rankedStock w
where
    rangDepot = 1
group by w.ARFOUR, w.ESARTI
)
,prepareDatestock as (
select
    w.ARFOUR, w.ESARTI
    , case when w.WXLSDERV = '0' then '01011900' else '0' || w.WXLSDERV end as WXLSDERV
    , w.WDDACH
from
    rankedStock w
where
    rang = 1
)
, calcStock AS (
    SELECT
        w.ARFOUR, w.ESARTI
        , SUBSTR(d.WXLSDERV, 1, 2) || '/' || SUBSTR(d.WXLSDERV, 3, 2) || '/' || SUBSTR(d.WXLSDERV, 5, 4) AS WXLSDERV
        , SUBSTR(a.WDDACH, 7, 2) || '/' || SUBSTR(a.WDDACH, 5, 2) || '/' || SUBSTR(a.WDDACH, 1, 4) AS WDDACH
        , (w.maxWdpf * w.QteStock) AS vspf
        , w.QteStock
    FROM
        calcStockSum w
        inner join prepareDatestock d on w.ARFOUR = d.ARFOUR
                                        and w.ESARTI = d.ESARTI
        inner join calcDernierAchat a on w.ARFOUR = a.ARFOUR and w.ESARTI = a.ESARTI
)
, selectionSociete as (
SELECT distinct
    --0-5
	ARFOPRIX.APCODF, ARFOPRIX.APFOUR,
	ARFOPRIX.APDATE, ARFOPRIX.APQTUC, ARFOPRIX.APPCAT, ARFOPRIX.APPNET,
    --6-14
	ARFOPRIX.APPPNT, ARTFOUR.AFREFO, ARTFOUR.AFUACH, ARTFOUR.AFUCDE,
	ARTFOUR.AFSACH, ARTFOUR.AFGTAC, ARTIC.ARCHAP, ARTIC.ARSSCH, ARTIC.ARSVCO,
    --15-23
	ARTIC.ARGRST, ARTFOUR.AFMACH, ARTFOUR.AFREFG, ARTIC.ARLONG,
	ARTIC.ARLARG, ARTIC.ARHAUT, ARTIC.ARDIAM, ARTIC.ARPDS, ARTIC.ARZLB5,
    --24-33
	ARTIC.ARDEPO, FRNGTA.FGDESI, ARTIC.ARSUPP, ARTIC.ARDSUP, ARTIC.ARDISP,
	ARTFOUR.AFCACH, ARTIC.ARTPFX, ARTIC.ARNBTP, ARTIC.ARTPF2, ARTIC.ARNBT2,
    --34-37
    ARTIC.ARTPF3, ARTIC.ARNBT3, ARTIC.ARTPF4, ARTIC.ARNBT4,
    --38-39
    STATVENE.CA, STATVENE.nb,
       
    --libellé 40-44
    chapi.chlib1, t.talibe, focli.clnom, ARTIC.ARDESI, art.SBLIBE,
    
    --codes 45-49
    artic.archap, artic.arssch, artic.arsvco, ARTIC.codeArticle, chapiF.chlib1 as famille,

    -- codes 50-51
    artic.argrtf, stb.salibe,
    
    -- codes 52-56
    artic.ARZLB1, artic.ARZLB2, artic.ARZLB3, artic.ARZLB4, artic.ARZLB5,
    
    -- codes 57-60
    artic.ARANCA, artic.ARUVEN, artic.ARUSTO, artic.ARUFAC,
    
    --codes 61-62
    artic.ARPDS, artic.ARVOLU,

    -- codes 63-69
    ARTFOUR.AFRFO2, ARTFOUR.AFRFCO, ARTFOUR.AFRFG2, ARTFOUR.AFTYPX, ARTFOUR.AFQPAL, ARTFOUR.AFCACI, ARTFOUR.AFQCAM 

    --codes 70
    , REMFO.RFGTAC
    
    --71-72
    , remfo.rfope1, remfo.rfrem1
    --73-74
    , remfo.rfope2, remfo.rfrem2
    --75-76
    , remfo.rfope3, remfo.rfrem3
    --77-78
    , remfo.rfope4, remfo.rfrem4
    --79-80
    , remfo.rfope5, remfo.rfrem5
    --81-85
    , concatprix.APDEPO_concatenated,  calcStock.QteStock, calcStock.vspf, calcStock.WXLSDERV, calcStock.WDDACH

FROM
    artic2 ARTIC
	INNER JOIN topprix as ARFOPRIX ON ARFOPRIX.APCODF = ARTIC.ARCODF and ARFOPRIX.rang = 1
	INNER JOIN COMAFICO.ARTFOUR ARTFOUR ON ARFOPRIX.APCODF = ARTFOUR.AFCODF
							             AND ARFOPRIX.APFOUR = ARTFOUR.AFFOUR
    inner join params on ARFOPRIX.APFOUR = params.idfour or params.idfour = ''
    inner join produits on (produits.ref <> '' and ARTFOUR.AFREFO = produits.ref)
                            or (produits.gencode <> '' and ARTFOUR.AFREFG = produits.gencode)
    left outer join calcStock calcStock on ARFOPRIX.APFOUR = calcStock.ARFOUR
                                        and ARTIC.codeArticle = calcStock.ESARTI
    left outer join concatprix concatprix on ARFOPRIX.APCODF = concatprix.APCODF
    LEFT OUTER JOIN statveneCA STATVENE ON ARTIC.codeArticle = STATVENE.STNART
                                                    AND ARFOPRIX.APFOUR = STATVENE.STNFOU
    left outer join comafico.chapi chapi on artic.archap = chapi.chcode
                                and artic.arssch = chapi.chssch
                                and artic.arsvco = chapi.chserv
    left outer join comafico.chapi chapiF on artic.archap = chapiF.chcode
                                and chapiF.chssch = ''
                                and artic.arsvco = chapiF.chserv
    left outer join COMPTACH.table t on artic.arsvco = t.taclef and  t.tanom = 'SERVI'
    left outer join COMAFICH.FOCLI focli on ARFOPRIX.APFOUR = focli.clclie and CLCS41 = 40
    left outer join comafico.artobs art on SUBSTR(ARTIC.codeArticle,1,6) = SUBSTR(art.SBCLEF,1,6)
                                            AND (art.sbsbib IS NULL OR TRIM(art.sbsbib) = '')
                                            AND (art.sbcdep IS NULL OR TRIM(art.sbcdep) = '')
    left outer join COMAFICH.STABLE stb on artic.arsvco = stb.saserv
                                        and artic.argrtf = stb.saclef
                                        and stb.sanom = 'GRTF'
    left outer join gta as FRNGTA on ARTFOUR.AFGTAC = FRNGTA.FGGTAC
                                          and ARTFOUR.AFFOUR = FRNGTA.FGFOUR
                                          and artic.arsvco = FRNGTA.FGSERV
                                          and FRNGTA.rang = 1
     left outer join topremfo remfo on ARTFOUR.AFGTAC = REMFO.RFGTAC and ARTFOUR.AFFOUR = remfo.rffour
)
select * from selectionSociete";

        private string QueryFour(string valuesTable) => $@"with four as (
select
    coalesce(s.CLCLIE, g.FGFOUR) as FGFOUR,
    coalesce(s.CLNOM, g.FGNOM) as FGNOM,
    concat(case when s.CLCLIE is null then '' else 'societe/' end
    ,case when g.FGFOUR is null then '' else 'groupe' end) as ori
from
    COMAGR_FIC.FOUGROU g
    full join COMAFICH.FOCLI40 s on g.FGFOUR = s.clclie
)
,produit AS (
    SELECT t.col1 AS ref, t.col2 AS gencode--, t.col3 as codeArticle 
    FROM 
        {valuesTable}
)
, artic2 as (
select
    CONCAT(ARTIC.ARCODS,ARTIC.ARCODF) as codeArticle
    , artic.*
from
    COMAFICO.ARTIC ARTIC
)
, rankedprix as (
select
    DENSE_RANK() OVER (PARTITION BY prix.APCODF, prix.APFOUR ORDER BY prix.APDATE DESC) AS rang,
    prix.*
from
    COMAFICO.ARTIC ARTIC
	INNER JOIN COMAFICO.ARFOPRIX prix ON prix.APCODF = ARTIC.ARCODF
where
    APQTUC = '0.000'
    and APDEPO = ''
)
, topprix as (select * from rankedprix where rang = 1)
,selectionProduit as (
select
    ARTFOUR.AFFOUR as four
    , ARTFOUR.AFREFO as ref, ARTFOUR.AFREFG as gencode, ARTIC.codeArticle as codeArticle
    , 'ste' as oriart
from
    artic2 ARTIC
	INNER JOIN topprix as ARFOPRIX ON ARFOPRIX.APCODF = ARTIC.ARCODF and ARFOPRIX.rang = 1
	INNER JOIN COMAFICO.ARTFOUR ARTFOUR ON ARFOPRIX.APCODF = ARTFOUR.AFCODF
							             AND ARFOPRIX.APFOUR = ARTFOUR.AFFOUR
    inner join produit on (produit.ref = '' or ARTFOUR.AFREFO = produit.ref) 
                            and (produit.gencode = '' or ARTFOUR.AFREFG = produit.gencode)
                            --and (produit.codeArticle = '' or produit.codeArticle = ARTIC.codeArticle)
)
, restrictARTGROU as (
select distinct
    ARTGROU.AGFOUR as four
    , ARTGROU.AGREFO as ref, ARTGROU.AGREFG as gencode, '' as codeArticle
    , 'grp' as oriart
from
    COMAGR_FIC.ARTGROU ARTGROU
    inner join produit on (produit.ref = '' or ARTGROU.AGREFO = produit.ref) 
                            and (produit.gencode = '' or ARTGROU.AGREFG = produit.gencode)
                            and not (produit.ref = '' and produit.gencode = '')
)
,selectedFour1 as (
select
    f.ori,
    f.FGFOUR, f.FGNOM,
    s.ref, s.gencode, s.codeArticle, s.oriart
from
    four f
    inner join selectionProduit s on f.FGFOUR = s.four
)
,selectedFour2 as (
select
    f.ori,
    f.FGFOUR, f.FGNOM,
    s.ref, s.gencode, s.codeArticle, s.oriart
from
    four f
    inner join restrictARTGROU s on f.FGFOUR = s.four
)
, selectedFour as (
select
    COALESCE(s1.ori,s2.ori) as ori,
    COALESCE(s1.FGFOUR,s2.FGFOUR) as FGFOUR,
    COALESCE(s1.FGNOM, s2.FGNOM) as FGNOM,
    --COALESCE(s1.ref,s2.ref) as ref,
    --COALESCE(s1.gencode,s2.gencode) as gencode,
    --s1.codeArticle as codeArticle,
    COALESCE(s1.oriart,'') || '/' || COALESCE(s2.oriart,'') as oriart
from
    selectedFour2 s2
    full outer join selectedFour1 s1 on s2.ref = s1.ref and s2.gencode = s1.gencode
)
select distinct * from selectedFour";
    }
}
