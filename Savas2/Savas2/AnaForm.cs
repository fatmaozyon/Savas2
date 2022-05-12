using Savas.Library.Concrete;
using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas2
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun=new Oyun();

        public AnaForm()
        {
            InitializeComponent();

            _oyun.GecensureDegisti += Oyun_GecenSureDegisti;

        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());   // basılan tuşu dönderir

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UcaksavarıHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UcaksavarıHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
            }
        }
        private void Oyun_GecenSureDegisti(object sender,EventArgs e)
        {
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
                //$"{_oyun.GecenSure.Minutes}:{_oyun.GecenSure.Seconds.ToString("D2")}"; // ToString("D2") saniyenin çift haneli saymasını sağlar
        }
    }
}
