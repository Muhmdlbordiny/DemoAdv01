using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdv01
{
    internal class Employee:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary {  get; set; }
        public override string ToString()
        {
            return $"Id {Id} , Name : {Name}, Salary :{Salary}";
        }
        public override bool Equals(object? obj)
        {
            Employee? other = (Employee?)obj; // unsafe casting  May be throw Exception 
            return (this.Id ==other?.Id)&&(this.Name ==other?.Name)&&(this.Salary == other.Salary);
        }
        public override int GetHashCode()
        {
            //Id , Name , salary
            //return (this.Id.GetHashCode())+ (this.Name.GetHashCode())+(this.Salary.GetHashCode()) ;
            return HashCode.Combine(Id.GetHashCode(), Name.GetHashCode(), Salary.GetHashCode());
        }
        //based on Salary
        public int CompareTo(object? obj)
        {
            //Employee? passEmployee = (Employee?)obj; //Unsafe May throw Exception

            #region IsConditional [true -false]
            //if(obj is Employee passEmployee)
            //{
            //    return this.Salary.CompareTo(passEmployee.Salary);
            //}
            //return 1;
            #endregion
            #region As Casting
            Employee? passEmployee = obj as Employee;
            //Casting succeed in 2 cases 
            //1. obj is employee
            //2.obj is an object from class inherit from Employee

            //if faild will Return Null
            return this.Salary.CompareTo(passEmployee?.Salary);
            #endregion

            //return this.Salary.CompareTo(passEmployee?.Salary);
        }
        #region Operator over load
        //==
        // public static bool operator ==(Employee left, Employee right)
        //{
        //    //return (left.Id == right.Id)&& (left.Name == right.Name)&& (left.Salary == right.Salary);
        //    return left.Equals(right) ;
        //}
        //public static bool operator !=(Employee left, Employee right)
        //{
        //    //return (left.Id != right.Id) || (left.Name != right.Name) ||(left.Salary != right.Salary);
        //    return !left.Equals(right) ;
        //}
        #endregion
    }
}
