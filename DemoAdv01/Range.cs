using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdv01
{
    public class Range<T> where T : IComparable
    {
        public Range(T minumValue, T maxumValue)
        {
            MinumValue = minumValue;
            MaxumValue = maxumValue;
        }

        public static T MinumValue { get; set; }
        public static T MaxumValue { get; set; }
       
        public static bool IsInRange(T value)
        {
            
            return value.CompareTo(MinumValue) >= 0&&value.CompareTo(MaxumValue)<=0;     
        }
        //public T Length()
        //{
        //    return MaxumValue - MinumValue;
        //}
    }
}
