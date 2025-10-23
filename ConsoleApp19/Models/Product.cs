using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.Models
{
    internal class Product
    {
        public string MehsulAdi;
        public int MehsulQiymeti;

        public Product()
        {
            
        }
        public Product(string MehsulAdi, int MehsulQiymeti)
        {
            MehsulAdi = MehsulAdi;
            MehsulQiymeti = MehsulQiymeti;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Mehsul adi: {MehsulAdi} Mehsul qiymeti: {MehsulQiymeti}");
        }
    }
}
