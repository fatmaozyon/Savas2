//B201200050 Fatma Nur Özyön
using Savas.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Library.Concrete
{
    internal class Ucaksavar : Cisim
    {
        public Ucaksavar(int panelGenişligi, Size hareketAlaniBoyutlari):base(hareketAlaniBoyutlari)
        {
            Center = panelGenişligi / 2;
            HareketMesafesi = Width;
        }
    }
}
