namespace IslemLibrary
{
    public class DegisiklikleriIzle
    {
        public FileSystemWatcher Izle(string dizin)
        {
            return new FileSystemWatcher(dizin)
            {
                Filter = "*.*",
                Path = dizin,
                InternalBufferSize = 65536,
                IncludeSubdirectories = false,
                NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.FileName | NotifyFilters.Size,
                EnableRaisingEvents = true
            };
        }
    }
}