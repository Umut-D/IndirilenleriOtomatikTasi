namespace IslemLibrary
{
    public class Tarih
    {
        private readonly string _gun = DateTime.Now.ToShortDateString();
        private readonly string _saat = DateTime.Now.ToLongTimeString();

        public string Yazdir(FileSystemEventArgs e, string dizin)
        {
            return $"{_gun} {_saat} >>> {e.Name}, {dizin} dizinine taşındı.";
        }
    }
}