using IslemLibrary;

namespace IndirilenleriOtomatikTasi
{
    public partial class FrmAna : Form
    {
        private string _seciliKlasor = "";

        public FrmAna()
        {
            InitializeComponent();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {
            _seciliKlasor = DefaultIndirilenlerKlasoru();
            txtIndirilenlerKlasoru.Text = _seciliKlasor;

            Izle(_seciliKlasor);
        }

        private string DefaultIndirilenlerKlasoru()
        {
            var indirilenlerKlasoru = new IndirilenlerKlasoru();
            return indirilenlerKlasoru.Dizin();
        }

        private void Izle(string dizin)
        {
            var degisiklikleriIzle = new DegisiklikleriIzle();
            var izle = degisiklikleriIzle.Izle(dizin);

            izle.Created += OnCreated;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                var dosya = new Dosya(e.FullPath);
                var bilgi = dosya.Islem(e);

                if (!lboxBilgi.Items.Contains(bilgi))
                    lboxBilgi.Items.Add(bilgi);
            }));
        }

        private void BtnKlasorSec_Click(object sender, EventArgs e)
        {
            if (fbdKlasor.ShowDialog() != DialogResult.OK)
                return;

            _seciliKlasor = fbdKlasor.SelectedPath;

            Izle(_seciliKlasor);
            txtIndirilenlerKlasoru.Text = _seciliKlasor;
        }
    }
}