using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace StudentCountApplication
{
    public class Student
    {
        public string FName;
        public string LName;
        public static int num;
        public Student()
        {
            num++;
        }
        public static int GetNum()
        {
            return num;
        }
        public void PrintFullName(string FN, string LN)
        {
            string FullName;
            FName = FN;
            LName = LN;
            FullName = FName + " " + LName;
            Console.WriteLine("FullName: {0}", FullName);    
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Student s1 = new Student();
            s.PrintFullName("Rohan","Patwari");
             s1.PrintFullName("Rishi", "Patwari");
            Console.WriteLine("Total No Of Students: {0}", Student.GetNum());
            Console.ReadLine();
         
        }
    }
}
