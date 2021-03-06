//B201200050 Fatma Nur Özyön
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Interface;
using Savas.Library.Enum;
using static System.Net.Mime.MediaTypeNames;

namespace Savas.Library.Concrete
{
    public class Oyun : IOyun
    {
        public int skor;
        

        #region Alanlar

        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private readonly Timer _ucakOlusturmaTimer = new Timer { Interval = 2000 };
        private TimeSpan _gecenSure;
        private readonly Panel _ucaksavarPanel;
        private readonly Panel _savasAlaniPanel;
        private Ucaksavar _ucaksavar;
        private readonly List<Mermi> _mermiler = new List<Mermi>();
        private readonly List<Ucak> _ucaklar = new List<Ucak>();

        #endregion

        #region Olaylar     
        public event EventHandler GecensureDegisti;
        #endregion

        #region Ozellikler       
        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure
        {
            get => _gecenSure;
            set
            {
                _gecenSure = value;

                GecensureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion

        #region Metotlar

        public Oyun(Panel ucaksavarPanel,Panel savasAlaniPanel)
        {
            _ucaksavarPanel = ucaksavarPanel;
            _savasAlaniPanel = savasAlaniPanel;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _ucakOlusturmaTimer.Tick += UcakOlusturmaTimer_Tick;

        }
        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }
        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            MermileriHareketEttir();
            UcaklariHareketEttir();
            VurulanUcaklariCikar();
            
        }

        private void VurulanUcaklariCikar()
        {
            for (var i = _ucaklar.Count - 1; i >= 0; i--)
            {
                var ucak = _ucaklar[i];
                var vuranMermi = ucak.VurulduMu(_mermiler);
                if (vuranMermi is null) continue;
                _ucaklar.Remove(ucak);
                _mermiler.Remove(vuranMermi);
                _savasAlaniPanel.Controls.Remove(ucak);
                _savasAlaniPanel.Controls.Remove(vuranMermi);
                skor += 5;
            }            
        }

        private void UcaklariHareketEttir()
        {
            foreach(var ucak in _ucaklar)
            {
                var carptiMi=ucak.HareketEttir(Yon.Asagi);
                if (!carptiMi) continue;

                Bitir();
                break;
            }
        }

        private void UcakOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            UcakOlustur();
        }
        private void MermileriHareketEttir()
        {
            for(int i=_mermiler.Count-1;i>=0;i--)
            {
                var mermi = _mermiler[i];
                var carptiMi=mermi.HareketEttir(Yon.Yukari);
                if (carptiMi)
                {
                    _mermiler.Remove(mermi);
                    _savasAlaniPanel.Controls.Remove(mermi);
                }
            }
            
        }

        public void AtesEt()
        {
            if (!DevamEdiyorMu) return;

            var mermi = new Mermi(_savasAlaniPanel.Size,_ucaksavar.Center);
            _mermiler.Add(mermi);
            _savasAlaniPanel.Controls.Add(mermi);
 
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;

            ZamanlayicilariBaslat();
            UcaksavarOlustur();
            UcakOlustur();

        }

        private void UcakOlustur()
        {
            var ucak = new Ucak(_savasAlaniPanel.Size);
            _ucaklar.Add(ucak);
            _savasAlaniPanel.Controls.Add(ucak);

        }

        private void ZamanlayicilariBaslat()
        {
            _gecenSureTimer.Start();
            _hareketTimer.Start();
            _ucakOlusturmaTimer.Start();
        }

        private void UcaksavarOlustur()
        {
            _ucaksavar = new Ucaksavar(_ucaksavarPanel.Width, _ucaksavarPanel.Size);
            _ucaksavarPanel.Controls.Add(_ucaksavar);
            
        }
       
        private void Bitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
            ZamanlayicilariDurdur();
        }
        private void ZamanlayicilariDurdur()
        {
            _gecenSureTimer.Stop();
            _hareketTimer.Stop();
            _ucakOlusturmaTimer.Stop();
        }

        public void UcaksavariHareketEttir(Yon yon)   
        {
            if (!DevamEdiyorMu) return;
            _ucaksavar.HareketEttir(yon);
        }


        #endregion
    }

    
}
