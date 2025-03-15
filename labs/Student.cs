using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs
{
    class Student
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address {  get; set; }

        public Student() { SSN = 0; Name = "NO Name";Age = 0;Address = "NO Address"; }

        public Student(int sSN, string name, int age, string address)
        {
            SSN = sSN;
            Name = name;
            Age = age;
            Address = address;
        }
        public void Print() 
        {
            Console.WriteLine($"SSN : {SSN} \nName : {Name}\nAge : {Age}\nAddress : {Address}");

        }
    }
}
