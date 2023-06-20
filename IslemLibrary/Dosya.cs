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
            switch (dosyaBilgi.Extension)
            {
                case ".doc" or ".docx" or ".xls" or ".xlsx" or ".ppt" or ".pptx" or ".txt":
                    Tasi(HedefDizin.Belgelerim, dosyaBilgi);
                    return tarih.Yazdir(e, nameof(HedefDizin.Belgelerim));
                case ".jpg" or ".jpeg" or ".png" or ".gif":
                    Tasi(HedefDizin.Resimlerim, dosyaBilgi);
                    return tarih.Yazdir(e, nameof(HedefDizin.Resimlerim));
                case ".mp3" or ".wav":
                    Tasi(HedefDizin.Muziklerim, dosyaBilgi);
                    return tarih.Yazdir(e, nameof(HedefDizin.Muziklerim));
                case ".mp4" or ".avi" or ".mov":
                    Tasi(HedefDizin.Videolar, dosyaBilgi);
                    return tarih.Yazdir(e, nameof(HedefDizin.Videolar));
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