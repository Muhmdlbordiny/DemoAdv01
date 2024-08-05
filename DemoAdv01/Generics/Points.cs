using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdv01.Generics
{
    internal class Points:IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Points(int x ,int y)
        {
            X= x;
            Y= y;
        }
        public override string ToString()
        {
            return $"{X} , {Y}";
        }

        public int CompareTo(object? obj)
        {
            if(obj is Points passpoint)
            {
                if(this.X == passpoint.X)
                    return this.Y.CompareTo(passpoint.Y);
                else
                   return this.X.CompareTo(passpoint.X);
            }
            return 1;

        }
    }
}
