using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL4
{
    internal class Pants:Cloth
    {
        public bool Rem { get; set; }
        public override string ToString()
        {
            string rem = Rem ? "- з тонким ременем" : "- з шкіряним ременем";
            return $"{base.ToString()} {rem}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Pants cloth = (Pants)obj;
            return Rem == cloth.Rem;
        }
        public override void Put()
        {
            Console.WriteLine("Натягнути штанці");
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Rem);
        }
    }
}