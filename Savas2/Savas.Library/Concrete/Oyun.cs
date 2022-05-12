using System;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Interface;
using Savas.Library.Enum;

namespace Savas.Library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar
        private Timer _gecenSureTimer = new Timer() { Interval = 1000 }; // her 1 saniyede tik olayını tetikler
        private TimeSpan _gecenSure;
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

        public Oyun()
        {
            _gecenSureTimer.Tick += GecenSureTimer_Tick;

        }
        
        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }

        public void AtesEt()
        {
            throw new NotImplementedException();
        }
        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;
            _gecenSureTimer.Start();

        }
        private void Bitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
            _gecenSureTimer.Stop();
        }
        public void UcaksavarıHareketEttir(Interface.Yon yon)  // hocada farklı
        {
            throw new NotImplementedException();
        }

        public void UcaksavarıHareketEttir(Enum.Yon saga)   //  hocada farklı
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
