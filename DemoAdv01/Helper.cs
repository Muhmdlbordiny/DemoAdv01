using DemoAdv01.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdv01
{
    internal class Helper<T> where T :  notnull,IComparable
    {
        #region NonGeneric
        //public static void BubleSort(int[] array)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int K = 0; K < array.Length - i - 1; K++)
        //            {
        //                if (array[K] > array[K + 1])
        //                    Swap<int>(ref array[K], ref array[K + 1]);
        //            }
        //        }
        //    }
        //}

        //public static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;


        //}
        //public static void Swap(ref double X , ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void Swap(ref Points X , ref Points Y)
        //{
        //    Points Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        //public static int SearchArray(int[]array, int value)
        //{
        //    if(array is not null)
        //    {
        //        for(int i = 0; i < array.Length; i++) 
        //        {
        //            if (value == array[i])
        //                return i;
        //        }
        //    }
        //    return -1;
        //}


        #endregion
        #region Generic
        //public static T Sum(T X, T Y)
        //{
        //    return X + Y; //Invaild 

        //}
        //T => Generic 
        //Swap => Generic Method
        public static void Swap(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        //public static int SearchArray<T>(T[] array, T value)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (value.Equals( array[i]))
        //                return i;
        //        }
        //    }
        //    return -1;
        //}

        public static void BubleSort(T[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int K = 0; K < array.Length - i - 1; K++)
                    {
                        if (array[K].CompareTo(array[K + 1]) == 1)
                            Swap(ref array[K], ref array[K + 1]);
                    }
                }
            }
        }
        #endregion
    }
}
