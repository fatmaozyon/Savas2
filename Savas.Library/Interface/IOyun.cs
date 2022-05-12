//B201200050 Fatma Nur Özyön
using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas.Library.Interface
{
    internal interface IOyun  // internal sadece o assembly içerisinde kullanılmasını sağlar
    {
        event EventHandler GecensureDegisti;

        bool DevamEdiyorMu { get; }

        TimeSpan GecenSure { get; }

        void Baslat();

        void AtesEt();

        void UcaksavariHareketEttir(Yon yon);

    }
}
