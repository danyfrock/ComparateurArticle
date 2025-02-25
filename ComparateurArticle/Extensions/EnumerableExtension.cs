namespace ComparateurArticle.Extensions
{
    public static class EnumerableExtension
    {
        //should be a classic chunk
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> source, int size)
        {
            return source
                .Select((value, index) => new { Index = index, Value = value })
                .GroupBy(x => x.Index / size)
                .Select(g => g.Select(x => x.Value));
        }

        //should be a classic chunk
        public static IEnumerable<IEnumerable<T>> ChunkData<T>(this IEnumerable<T> source, int chunkSize)
        {
            while (source.Any())
            {
                yield return source.Take(chunkSize);
                source = source.Skip(chunkSize);
            }
        }

    }//classe
}//namespace
