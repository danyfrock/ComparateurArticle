using ClosedXML.Excel;
using System.Data;

namespace ComparateurArticle.ExcelReaders
{
    public class ExcelExport
    {
        public void ExporterVersExcel(DataTable dataTable, string filePath)
        {
            // Créer un nouveau classeur Excel
            using (var workbook = new XLWorkbook())
            {
                // Ajouter une nouvelle feuille
                var worksheet = workbook.Worksheets.Add("Données");

                // Insérer les données du DataTable dans la feuille
                worksheet.Cell(1, 1).InsertTable(dataTable);

                // Sauvegarder le fichier Excel
                workbook.SaveAs(filePath);
            }
        }

    }//classe
}//namespace
