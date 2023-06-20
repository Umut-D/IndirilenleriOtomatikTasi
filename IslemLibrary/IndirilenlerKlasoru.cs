using System.Runtime.InteropServices;

namespace IslemLibrary
{
    public class IndirilenlerKlasoru
    {
        private readonly Guid _indirilenler = new Guid("374DE290-123F-4565-9164-39C4925E467B");

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
            IntPtr hToken, out string pszPath);

        public string Dizin()
        {
            SHGetKnownFolderPath(_indirilenler, 0, IntPtr.Zero, out var indirilenlerKlasoru);
            return indirilenlerKlasoru;
        }
    }
}