namespace IndirilenleriOtomatikTasi
{
    partial class FrmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lboxBilgi = new ListBox();
            txtIndirilenlerKlasoru = new TextBox();
            fbdKlasor = new FolderBrowserDialog();
            btnKlasorSec = new Button();
            gBox = new GroupBox();
            gBox.SuspendLayout();
            SuspendLayout();
            // 
            // lboxBilgi
            // 
            lboxBilgi.FormattingEnabled = true;
            lboxBilgi.HorizontalScrollbar = true;
            lboxBilgi.ItemHeight = 35;
            lboxBilgi.Location = new Point(6, 102);
            lboxBilgi.Name = "lboxBilgi";
            lboxBilgi.Size = new Size(631, 354);
            lboxBilgi.TabIndex = 0;
            // 
            // txtIndirilenlerKlasoru
            // 
            txtIndirilenlerKlasoru.Location = new Point(6, 41);
            txtIndirilenlerKlasoru.Name = "txtIndirilenlerKlasoru";
            txtIndirilenlerKlasoru.ReadOnly = true;
            txtIndirilenlerKlasoru.Size = new Size(452, 41);
            txtIndirilenlerKlasoru.TabIndex = 1;
            // 
            // btnKlasorSec
            // 
            btnKlasorSec.Location = new Point(477, 40);
            btnKlasorSec.Name = "btnKlasorSec";
            btnKlasorSec.Size = new Size(142, 44);
            btnKlasorSec.TabIndex = 2;
            btnKlasorSec.Text = "Klasör Seç";
            btnKlasorSec.UseVisualStyleBackColor = true;
            btnKlasorSec.Click += BtnKlasorSec_Click;
            // 
            // gBox
            // 
            gBox.Controls.Add(txtIndirilenlerKlasoru);
            gBox.Controls.Add(lboxBilgi);
            gBox.Controls.Add(btnKlasorSec);
            gBox.Location = new Point(12, 12);
            gBox.Name = "gBox";
            gBox.Size = new Size(643, 476);
            gBox.TabIndex = 3;
            gBox.TabStop = false;
            gBox.Text = "İzlenecek Klasörü Seçin";
            // 
            // FrmAna
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 500);
            Controls.Add(gBox);
            Font = new Font("Segoe UI", 9.89011F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İndirilenleri Otomatik Taşı";
            Load += FrmAna_Load;
            gBox.ResumeLayout(false);
            gBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lboxBilgi;
        private TextBox txtIndirilenlerKlasoru;
        private FolderBrowserDialog fbdKlasor;
        private Button btnKlasorSec;
        private GroupBox gBox;
    }
}