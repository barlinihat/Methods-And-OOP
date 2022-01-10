using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //İnterface'ler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır.
    //Hesaplama(); gibi.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
