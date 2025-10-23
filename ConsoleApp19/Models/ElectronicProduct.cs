using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.Models
{
    internal class ElectronicProduct: Product
    {
        public int ZemanetMuddeti;

        public ElectronicProduct()
        {
            
        }
        public ElectronicProduct(string MehsulAdi, int MehsulQiymeti, int ZemaneMuddeti):base(MehsulAdi,MehsulQiymeti)
        {
            ZemaneMuddeti = ZemaneMuddeti;
            ShowInfo();
        }
        public void Zemanet()
        {
            Console.WriteLine($"Zemanet muddeti: {ZemanetMuddeti} il");
        }
    }
}
