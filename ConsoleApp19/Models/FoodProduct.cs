using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.Models
{
    internal class FoodProduct: Product
    {
        public int IstifadeMuddeti;
        public FoodProduct()
        {
            
        }
        public FoodProduct(string MehsulAdi, int MehsulQiymeti, int IstifadeMuddeti):base(MehsulAdi,MehsulQiymeti)
        {
            IstifadeMuddeti = IstifadeMuddeti;
            ShowInfo();
        }
        public void Muddet()
        {
            Console.WriteLine($"Istifade muddeti: {IstifadeMuddeti} ay");
        }

    }
}
