using System.Drawing;
using DemoAdv01.Generics;
namespace DemoAdv01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic
            //int A = 10; int B = 20;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.Swap<int>(ref A, ref B);
            //Console.WriteLine("After swaping :");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //double X = 10; double Y = 20;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.Swap<double>(ref X, ref Y);
            //Console.WriteLine("After swaping :");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Points p01 = new Points(1, 2);
            //Points p02 = new Points(10, 20);
            //Console.WriteLine(p01);
            //Console.WriteLine(p02);
            //Helper.Swap<Points>(ref p01, ref p02);
            //Console.WriteLine(p01);
            //Console.WriteLine(p02);

            #endregion
            #region Generic [search Ex]
            //int[] Numbers = { 4, 5, 7, 8, 9, 10, 15 };
            //int index = Helper.SearchArray<int>(Numbers, 8);
            //Console.WriteLine(index);
            //Employee emp1 = new Employee() { Id =10, Name= "Mohamed", Salary =1000};
            //Employee emp2 = new Employee() { Id =20, Name= "Ahmedd", Salary =2000};
            // //if(emp1== emp2)
            // //    Console.WriteLine("equal");
            // //else
            // //    Console.WriteLine("Not equal");
            // if (emp1.Equals( emp2))
            //     Console.WriteLine("equal");
            // else
            //     Console.WriteLine("Not equal");
            // Employee E03 = new Employee() { Id = 50, Name = "Mona", Salary = 5000 };
            // Employee[] employees = new Employee[2]
            // {
            //     new Employee(){Id =10, Name ="Aya", Salary =1000},
            //     new Employee(){Id =100, Name = "Mohamed", Salary=1000}
            // };
            //int index = Helper.SearchArray<Employee>(employees,E03);
            // Console.WriteLine(index);
            Console.WriteLine("==============================");
            //Employee emp1 = new Employee() { Id = 10, Name = "Mohamed", Salary = 1000 };
            //Employee emp2 = new Employee() { Id = 10, Name = "Mohamed", Salary = 1000 };
            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());
            ////if (emp1 == emp2) // compare Refernces
            ////    Console.WriteLine("equal");
            ////else
            ////    Console.WriteLine("Not equal");
            //if (emp1.Equals( emp2)) // compare  object state because using Overloading 
            //    Console.WriteLine("equal");
            //else
            //    Console.WriteLine("Not equal");
            #endregion
            #region Generics BubbleSort
            //int[] Numbers = { 12, 25, 3, 6, 9, 5, 20, 1, 2, 10 };
            //foreach (int item in Numbers)
            //    Console.Write( $" { item } ");
            //Console.WriteLine("\n *****************");
            //Helper.BubleSort( Numbers );
            //foreach (int item in Numbers)
            //    Console.Write($" , {item} ");
            //Employee[] employees = new Employee[]
            //{
            //    new Employee(){Id=10, Name ="Mohamed",Salary = 5000},
            //    new Employee(){Id=20, Name ="Ahmed",Salary = 6000},
            //    new Employee(){Id=30, Name ="Ali",Salary = 7000},
            //    new Employee(){Id=40, Name ="Ali",Salary = 7000}
            //};
            //Helper<Employee>.BubleSort(employees);
            //foreach (Employee employee in employees)
            //    Console.WriteLine(employee
            //Points[] points = { new Points(7, 2), new Points(2, 5), new Points(6, 4), new Points(7, 3) };
            //Helper<Points>.BubleSort(points);
            //foreach (Points p in points)
            //    Console.WriteLine(p);
            #endregion
            #region Assignment
            #region Q1
            /*1.	The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, 
             * which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
                And implement the code of this optimized bubble sort algorithm
            
             */
            int[] Numbers = { 5, 7, 2, 3, 1, 4, 9, 10 };
            foreach (int i in Numbers)
                Console.WriteLine($" {i} ");
            Helper<int>.BubleSort(Numbers);
            foreach (int i in Numbers)
                Console.WriteLine($" {i} ");

            #endregion
            #region Q2

            #endregion
            #endregion

        }
    }
}
