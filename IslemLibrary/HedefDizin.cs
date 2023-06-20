namespace IslemLibrary
{
    public class HedefDizin
    {
        public static string Belgelerim => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string Muziklerim => Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public static string Resimlerim => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        public static string Videolar => Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
    }
}