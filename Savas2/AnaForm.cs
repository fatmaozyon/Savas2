//B201200050 Fatma Nur Özyön
using Savas.Library.Concrete;
using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas2
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;
       
        

        public AnaForm()
        {
            InitializeComponent();

            _oyun = new Oyun(ucaksavarPanel,savasAlaniPanel);

            _oyun.GecensureDegisti += Oyun_GecenSureDegisti;
            skorlbl.Text = "Skor:"+_oyun.skor.ToString();

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
                        _oyun.UcaksavariHareketEttir(Yon.Saga);
                break;
                    case Keys.Left:
                        _oyun.UcaksavariHareketEttir(Yon.Sola);
                break;
                    case Keys.Space:
                        _oyun.AtesEt();
                break;
                
               }

            if (e.KeyCode.ToString() == "Escape")
            {
                menu.Visible = true;
                
            }
        }
        private void Oyun_GecenSureDegisti(object sender,EventArgs e)
        {
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
            //$"{_oyun.GecenSure.Minutes}:{_oyun.GecenSure.Seconds.ToString("D2")}"; // ToString("D2") saniyenin çift haneli saymasını sağlar
            skorlbl.Text = "Skor:"+_oyun.skor.ToString();
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
            this.Focus();
            
        }
        private void sureLabel_Click(object sender, EventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
