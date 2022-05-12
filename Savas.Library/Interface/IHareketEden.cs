//B201200050 Fatma Nur Özyön
using System;
using Savas.Library.Enum;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas.Library.Interface
{
    interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }

        int HareketMesafesi { get; }


        /// <summary>
        /// Cismi istenilen yönde hareket ettirir
        /// </summary>
        /// <param name="yon"> Hangi yönde hareket edileceği</param>
        /// <returns>Cisim duvara çarparsa true dönderir</returns>
        bool HareketEttir(Yon yon);
    }
}
