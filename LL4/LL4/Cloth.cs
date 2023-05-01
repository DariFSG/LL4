using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LL4
{
    public class Cloth
    {
        public string Bran { get; set; }
        public string Col { get; set; }
        public string Size { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Cloth cloth= (Cloth)obj;
            return Bran == cloth.Bran &&
                Col == cloth.Col && 
                Size == cloth.Size;
        }
        public override string ToString()
        {
            return $"{Bran}, {Col}, {Size}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Bran, Col, Size);
        }
        public virtual void Put()
        {
            Console.WriteLine("Одягнутися");
        }
        public void Dress(int ch)
        {
            Pants pants = new();
            Jack jack = new();
            Shoe shoe = new();
            Shirt shirt = new();
            if (ch == 1)
            {
                Console.WriteLine("Обрано сорочку");
                shirt.Bran = "Zolo";
                shirt.Col = "Purple";
                shirt.Size = "XXXL";
                Console.WriteLine(shirt.ToString());
                Console.WriteLine(shirt.Equals(jack));
                Console.WriteLine("HashCode: " + shirt.GetHashCode());
                shirt.Put();
            }
            else if (ch == 2)
            {
                Console.WriteLine("Обрано куртку");
                jack.Bran = "Pork";
                jack.Col = "White";
                jack.Size = "M";
                Console.WriteLine(jack.ToString());
                Console.WriteLine("HashCode: " + jack.GetHashCode());
                jack.Put();
            }
            else if (ch == 3)
            {
                Console.WriteLine("Обрано штани");
                pants.Bran = "Gussi";
                pants.Col = "Blue";
                pants.Size = "XS";
                Console.WriteLine(pants.ToString());
                Console.WriteLine(pants.Equals(shoe));
                Console.WriteLine("HashCode: " + pants.GetHashCode());
                pants.Put();
            }
            else if (ch == 4)
            {
                Console.WriteLine("Обрано взуття");
                shoe.Bran = "TimberLomb";
                shoe.Col = "Black";
                shoe.Size = "43";
                Console.WriteLine(shoe.ToString());
                Console.WriteLine("HashCode: " + shoe.GetHashCode());
                shoe.Put();
            }
        }   
    }
}