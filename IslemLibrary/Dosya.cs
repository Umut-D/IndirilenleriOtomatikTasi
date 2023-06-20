namespace IslemLibrary
{
    public class Dosya
    {
        private readonly string _dizin;

        public Dosya(string dizin)
        {
            _dizin = dizin;
        }

        public string Islem(FileSystemEventArgs e)
        {
            Tarih tarih = new Tarih();
            FileInfo dosyaBilgi = new FileInfo(_dizin);
            string hedefDizin;
            switch (dosyaBilgi.Extension)
            {
                case ".doc" or ".docx" or ".xls" or ".xlsx" or ".ppt" or ".pptx" or ".txt":
                    hedefDizin = HedefDizin.Belgelerim;
                    Tasi(hedefDizin, dosyaBilgi);
                    return tarih.Yazdir(e, nameof(hedefDizin));
                case ".jpg" or ".jpeg" or ".png" or ".gif":
                    hedefDizin = HedefDizin.Resimlerim;
                    Tasi(hedefDizin, dosyaBilgi);
                    return tarih.Yazdir(e, nameof(hedefDizin));
                case ".mp3" or ".wav":
                    hedefDizin = HedefDizin.Muziklerim;
                    Tasi(hedefDizin, dosyaBilgi);
                    return tarih.Yazdir(e, nameof(hedefDizin));
                case ".mp4" or ".avi" or ".mov":
                    hedefDizin = HedefDizin.Videolar;
                    Tasi(hedefDizin, dosyaBilgi);
                    return tarih.Yazdir(e, nameof(hedefDizin));
                default:
                    return string.Empty;
            }
        }

        private async void Tasi(string dizinler, FileInfo dosyaBilgi)
        {
            await TasimayiSiraliYap();

            if (File.Exists(_dizin))
            {
                var hedefDosyaAdi = dizinler + @"\" + dosyaBilgi.Name;
                File.Move(_dizin, hedefDosyaAdi, true);
                File.SetAttributes(dizinler, FileAttributes.Normal);
            }
        }

        private static async Task TasimayiSiraliYap()
        {
            // Bu seçenek olmayınca Windows, 2. ve sonraki dosyaları aktarma yapmamakta?
            await Task.Delay(TimeSpan.FromSeconds(2)).ConfigureAwait(false);
        }
    }
}