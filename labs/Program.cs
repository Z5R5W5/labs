using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static labs.CalculateSalaryEmp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace labs
{
    
    internal class Program
    {
        static Tuple<int, int> Max_Min(int[] arr)
        {
            int ma = arr[0], mi = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > ma)
                {
                    ma = arr[i];
                }
                if (arr[i] < mi)
                {
                    mi = arr[i];
                }
            }
            Tuple<int, int> RValue = new Tuple<int, int>(mi, ma);
            return RValue;
        }
        static void sort(int[] arr)
        {
            bool swapped = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    swapped = true;
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }

                }
                if (swapped != true) { break; }
            }
        }

        static void swap(ref int[] arr, ref int i, ref int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        delegate int del(int x, int y);

        public delegate bool FilterDelegate(CEmployee emp);



        static void Main(string[] args)
        {
            #region exceptions
            //int x;
            //try
            //{
            //    checked
            //    {
            //        x = Int32.Parse(Console.ReadLine());

            //    }

            //}
            //catch (FormatException fex)
            //{
            //    Console.WriteLine("ththle");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region 1D array

            //int[] arr = new int[10];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"enter value {i+1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Tuple<int, int> pair = Max_Min(arr);
            //Console.WriteLine($" max value is {pair.Item2} \n min value is {pair.Item1}");
            //sort(arr);
            //for (int i = 0; i < arr.Length; i++)

            //{
            //    Console.Write(arr[i]);
            //}
            //Console.WriteLine(string.Join(", ",arr));

            #endregion

            #region 2D array
            //int[,] arr2 = new int[3, 2];


            //for(int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    Console.Write($"enter std {i + 1} : ");
            //    for(int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write($"\tgrade num {j + 1} : ");
            //        arr2[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arr2.GetLength(1); i++)
            //{
            //    int vv = 0;
            //    Console.Write($"grade {i + 1} : ");
            //    for (int j = 0; j < arr2.GetLength(0); j++)
            //    {
            //        vv += arr2[j, i];

            //    }
            //    Console.WriteLine($"avarage of sub{i+1} is {vv}");
            //}
            #endregion


            #region lab  3
            //do
            //{
            //    int x = 0;

            //    Console.WriteLine("Enter choice \n1) one Empoloyee \t 2) mor than Employee");
            //    Console.WriteLine($"Your choise please : ");
            //    x = int.Parse(Console.ReadLine());


            //    switch (x)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter data of one Employee : \n");
            //            Empoloyee emp= new Empoloyee();

            //            Console.Write("Enter SSN : ");
            //            emp.SetSSN(int.Parse(Console.ReadLine()));

            //            Console.Write("Enter First Name : ");
            //            emp.SetFname(Console.ReadLine());

            //            Console.Write("Enter Last Name : ");
            //            emp.SetLname(Console.ReadLine());
            //            bool isvaled ;
            //            do {

            //                try
            //                {
            //                    Console.Write("Enter Age : ");
            //                    emp.Setage(int.Parse(Console.ReadLine()));
            //                    isvaled = true;
            //                }
            //                catch (Exception ex)
            //                {
            //                    Console.Write("Re ");
            //                    isvaled = false;

            //                }
            //            } while (!isvaled);


            //            do
            //            {
            //                try
            //                {
            //                    Console.Write("Enter Address : ");
            //                    emp.SetAddress(Console.ReadLine());
            //                    isvaled = true;

            //                }
            //                catch(Exception ex)
            //                {
            //                    Console.Write("Re ");
            //                    isvaled = false;

            //                }
            //            } while (!isvaled);



            //            emp.Print_Data();

            //            break;
            //        case 2:
            //            Console.WriteLine($"Enter number of employee : ");
            //            int ind = int.Parse(Console.ReadLine());
            //            Empoloyee[] emps= new Empoloyee[ind]; 
            //            for(int i = 0; i < emps.Length; i++)
            //            {
            //                Console.Write("Enter SSN : ");
            //                emps[i].SetSSN(int.Parse(Console.ReadLine()));

            //                Console.Write("Enter First Name : ");
            //                emps[i].SetFname(Console.ReadLine());

            //                Console.Write("Enter Last Name : ");
            //                emps[i].SetLname(Console.ReadLine());
            //                bool isvaled2;
            //                do
            //                {

            //                    try
            //                    {
            //                        Console.Write("Enter Age : ");
            //                        emps[i].Setage(int.Parse(Console.ReadLine()));
            //                        isvaled2 = true;
            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        Console.Write("Re ");
            //                        isvaled2 = false;

            //                    }
            //                } while (!isvaled2);


            //                do
            //                {
            //                    try
            //                    {
            //                        Console.Write("Enter Address : ");
            //                        emps[i].SetAddress(Console.ReadLine());
            //                        isvaled2 = true;

            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        Console.Write("Re ");
            //                        isvaled2 = false;

            //                    }
            //                } while (!isvaled2);



            //                //emps[i].Print_Data();

            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invaled choise ");
            //            break;
            //    }
            //}while(true);
            #endregion


            #region coments


            //int[] arr= { 1, 3, 6, 5 };
            //int x = 0, y = 3;

            //swap(ref arr,ref x,ref y );

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}

            //MyMath mat = new MyMath();
            //mat.X = 5;
            //mat.Y = 3;
            //Console.WriteLine(mat.Add());


            //Student std1=new Student();
            //Console.Write("Enter SSN : ");
            //std1.SSN = int.Parse(Console.ReadLine());

            //Console.Write("Enter Name : ");
            //std1.Name= Console.ReadLine();

            //Console.Write("Enter Age : ");
            //std1.Age = int.Parse(Console.ReadLine());

            //Console.Write("Enter Address : ");
            //std1.Address = Console.ReadLine();

            //std1.Print();

            //        Student[] students = new Student[3];
            //        for (int i = 0; i < students.Length; i++) 
            //        {
            //            students[i] = new Student();
            //            Console.Write($"Enter SSN std {i+1} : ");
            //            students[i].SSN = int.Parse(Console.ReadLine());

            //            Console.Write($"Enter Name std {i+1} : ");
            //            students[i].Name = Console.ReadLine();

            //            Console.Write($"Enter Age std {i+1} : ");
            //            students[i].Age = int.Parse(Console.ReadLine());

            //            Console.Write($"Enter Address std {i+1} : ");
            //            students[i].Address = Console.ReadLine();

            //        }
            //        for (int i = 0; i < students.Length; i++) 
            //        {
            //            //students[i] = new Student();
            //            students[i].Print();

            //        }
            #endregion

            #region Delegates & Events
            //calculator(2, 3, Add);

            //static void calculator(int x1, int y1, del de)
            //{
            //    int x = de(x1, y1);


            //    Console.WriteLine($"Add = {x}");

            //}
            //static int Add(int x = 2, int y = 3)
            //{
            //    return x + y;
            //}
            //static int Sub(int x, int y)
            //{
            //    return x - y;

            //    Student[] students = new Student[3];
            //    for (int i = 0; i < students.Length; i++)
            //    {
            //        students[i] = new Student();
            //        Console.Write($"Enter SSN std {i + 1} : ");
            //        students[i].SSN = int.Parse(Console.ReadLine());

            //        Console.Write($"Enter Name std {i + 1} : ");
            //        students[i].Name = Console.ReadLine();

            //        Console.Write($"Enter Age std {i + 1} : ");
            //        students[i].Age = int.Parse(Console.ReadLine());

            //        Console.Write($"Enter Address std {i + 1} : ");
            //        students[i].Address = Console.ReadLine();

            //    }
            //    for (int i = 0; i < students.Length; i++)
            //    {
            //        //students[i] = new Student();
            //        students[i].Print();

            //    }

            //List<CEmployee> empList = new List<CEmployee>();
            //for(int i = 0; i < 100; i++)
            //{
            //    CEmployee emp = new CEmployee();
            //    emp.Id = i;
            //    emp.Name = "emp" + i;
            //    emp.Salary = 1000 + i * 10;
            //    empList.Add(emp);
            //}
            //CalculateSalaryEmp CalculateSalaryEm = new CalculateSalaryEmp();
            //CalculateSalaryEm.FilterEvent += FilterEventHandler;

            //CalculateSalaryEm.CalculateSalaryEmpE1(empList,(CEmployee emp) => { return emp.Salary > 1200; });
            //void FilterEventHandler(CEmployee emp, int salary)
            //{
            //    Console.WriteLine($"Id : {emp.Id} \nName : {emp.Name}\nSalary : {emp.Salary}");
            //}

            #endregion

            #region ASS2_Payed Cource
            #endregion
            #region ASS3_Payed Cource
            //1 - Write a program that takes a number from the user then print yes
            //if that number can be divided by 3 and 4 otherwise print no
            //int x=int.Parse(Console.ReadLine());
            //if (x % 3 == 0 && x % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            //2 - Write a program that allows the user to insert an integer
            //then print negative if it is negative number otherwise print positive.
            //int y = int.Parse(Console.ReadLine());
            //if (y < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}

            ////3 - Write a program that takes 3 integers from the user then
            ////prints the max element and the min element.
            //int[] arr = new int[3];
            //int mi, ma;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());


            //}
            //mi = ma = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > ma)
            //    {
            //        ma = arr[i];
            //    }
            //    if (arr[i] < mi)
            //    {
            //        mi = arr[i];
            //    }
            //}
            //Console.WriteLine($"max {ma} min {mi}");


            //4 - Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.

            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine((x%2==1) ? "odd": "even");

            //5 - Write a program that takes character from the user then
            //if it is a vowel chars(a, e, I, o, u) then print(vowel)
            //otherwise print(consonant).
            //char ch = char.Parse(Console.ReadLine());
            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') {
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}

            //6 - Write a program that allows the user to insert an integer then
            //print all numbers between 1 to that number.
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //7 - Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{ 
            //    Console.WriteLine($"{x} * {i} = {x * i}");
            //}

            //8 - Write a program that allows to user to insert number then print all 
            //    even numbers between 1 to this number
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //9 - Write a program that takes two integers then prints the power.
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int res = 1;
            //for (int i = 0; i < y; i++)
            //{
            //    res *= x;
            //}
            //Console.WriteLine(res);

            //int x =(int)Math.Pow(2, 3);
            //Console.WriteLine(x);

            //10 - Write a program to enter marks of five subjects and calculate total,
            //average and percentage.

            //int[] arr = new int[5];
            // int sum = 0;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write($"Enter marks {i + 1} : ");
            //     arr[i] = int.Parse(Console.ReadLine());
            //     sum += arr[i];
            // }
            // Console.WriteLine($"Total = {sum}");
            // Console.WriteLine($"Average = {sum / arr.Length}");
            // Console.WriteLine($"Percentage = {((sum / arr.Length) * 100 / 100 ) :P}");

            //11 - Write a program to input the month number and print the number of
            //days in that month.

            //int x = int.Parse(Console.ReadLine());
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("31");
            //        break;
            //    case 2:
            //        Console.WriteLine("28");
            //        break;
            //    case 3:
            //        Console.WriteLine("31");
            //        break;
            //    case 4:
            //        Console.WriteLine("30");
            //        break;
            //    case 5:
            //        Console.WriteLine("31");
            //        break;
            //    case 6:
            //        Console.WriteLine("30");
            //        break;
            //    case 7:
            //        Console.WriteLine("31");
            //        break;
            //    case 8:
            //        Console.WriteLine("31");
            //        break;
            //    case 9:
            //        Console.WriteLine("30");
            //        break;
            //    case 10:
            //        Console.WriteLine("31");
            //        break;
            //    case 11:
            //        Console.WriteLine("30");
            //        break;
            //    case 12:
            //        Console.WriteLine("31");
            //        break;
            //}

            //12 - Write a program to create a Simple Calculator.
            //int x = 0, y = 0;
            //char op = ' ';
            //Console.Write("Enter first number : ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number : ");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("Enter operator : ");
            //op = char.Parse(Console.ReadLine());
            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine($"{x} + {y} = {x + y}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{x} - {y} = {x - y}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{x} * {y} = {x * y}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{x} / {y} = {x / y}");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //}

            //13 - Write a program to allow the user to enter a string and print the
            //REVERSE of it.

            //string str = Console.ReadLine();
            //Console.WriteLine(str[1]);
            //IEnumerable<char>  js = str.Reverse();
            //foreach(char c in js)
            //{
            //    Console.Write(c);
            //}
            //Console.WriteLine(str.Reverse().ToArray());
            //char[] arr = str.ToCharArray();
            //char[] arr2 = new char[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr2[i] = arr[arr.Length - 1 - i];
            //}
            //Console.WriteLine(arr2);

            //14 - Write a program to allow the user to enter int and print
            //the REVERSED of it

            //int x= int.Parse(Console.ReadLine());
            //string s= Convert.ToString(x);
            //var i = s.Reverse();
            //string s2=new string("");
            //foreach( char c in i)
            //{
            //     s2+= c;
            //}
            //int y = int.Parse(s2);
            //Console.WriteLine(y+1);
            //string s1= new string(x.ToString().Reverse().ToArray());

            //-Write a program in C# Sharp to find prime numbers within a range of
            //numbers.

            //int x = 0, y = 0;
            //Console.Write("Enter first number : ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number : ");
            //y = int.Parse(Console.ReadLine());

            //for (int i = x; i <= y; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime && i!=1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //16 - .Write a program in C# Sharp to convert a decimal number into
            //binary without using an array.
            //int x=int.Parse(Console.ReadLine());
            //string s = "";
            //while (x > 0)
            //{
            //    s += x % 2;
            //    x /= 2;
            //}
            //string s2 = "";
            //s2 = new string(s.Reverse().ToArray());
            //Console.WriteLine(s2);

            //17 - Create a program that asks the user to input three
            //points(x1, y1), (x2, y2), and(x3, y3), and determines whether
            //these points lie on a single straight line.

            //int x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0;
            //Console.Write("Enter x1 : ");
            //x1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y1 : ");
            //y1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter x2 : ");
            //x2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y2 : ");
            //y2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter x3 : ");
            //x3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y3 : ");
            //y3 = int.Parse(Console.ReadLine());
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //18 - Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined as follows: 
            //- If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //int x = 0;
            //Console.Write("Enter time : ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x);
            //if (x >= 2 && x <= 3)
            //{
            //    Console.WriteLine("highly efficient");
            //}
            //else if (x > 3 && x <= 4)
            //{
            //    Console.WriteLine("instructed to increase their speed");
            //}
            //else if (x > 4 && x <= 5)
            //{
            //    Console.WriteLine("provided with training to enhance their speed");
            //}
            //else if (x > 5)
            //{
            //    Console.WriteLine("required to leave the company");
            //}


            //19 - .Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity
            //table of size n * n

            //int n = 0;
            //Console.Write("Enter n : ");
            //n = int.Parse(Console.ReadLine());
            //int[,] arr = new int[n, n];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            arr[i, j] = 1;
            //        }
            //        else
            //        {
            //            arr[i, j] = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //20 - Write a program in C# Sharp to find the sum of all elements
            //of the array.

            //int[] arr = new int[5];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.WriteLine($"sum = {sum}");

            //21 - Write a program in C# Sharp to merge two arrays of the same size
            //sorted in ascending order.
            //int[] arr1 = new int[5];
            //int[] arr2 = new int[5];
            //int[] arr3 = new int[arr1.Length + arr2.Length];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1} of first array : ");
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1} of second array : ");
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr3[i] = arr1[i];
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr3[i + arr1.Length] = arr2[i];
            //}
            //sort(arr3);
            //Console.WriteLine("Merged array : ");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write(arr3[i] + "\t");
            //}
            //Console.WriteLine();

            //22 - Write a program in C# Sharp to count the frequency of each
            //element of an array
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //int[] freq = new int[n]; // to store frequencies
            //int visited = -1;

            //Console.WriteLine("Enter the elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    int count = 1;

            //    if (freq[i] == visited)
            //        continue;

            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            freq[j] = visited; // mark as counted
            //        }
            //    }

            //    freq[i] = count;
            //}

            //Console.WriteLine("\nFrequency of each element:");
            //for (int i = 0; i < n; i++)
            //{
            //    if (freq[i] != visited)
            //    {
            //        Console.WriteLine($"Element {arr[i]} occurs {freq[i]} time(s).");
            //    }
            //}









            #endregion




        }
    }

    #region Struct Employee
        public struct Empoloyee
    {
            private int SSN;
            private string Fname;
            private string Lname;
            private int Age;
            private string Address;

            public void SetSSN(int ssn)
            {
                this.SSN = ssn;

            }
            public void SetFname(string fname)
            {
                this.Fname = fname;
            }
            public void SetLname(string lname)
            {
                this.Lname = lname;
            }
            public void Setage(int age)
            {
                if (age >= 23 && age <= 45)
                {

                    this.Age = age;
                }
                else
                {
                    throw new Exception("invaled age ");
                }


            #region lab  3
            //do
            //{
            //    int x = 0;

            //    Console.WriteLine("Enter choice \n1) one Empoloyee \t 2) mor than Employee");
            //    Console.WriteLine($"Your choise please : ");
            //    x = int.Parse(Console.ReadLine());


            //    switch (x)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter data of one Employee : \n");
            //            Empoloyee emp= new Empoloyee();

            //            Console.Write("Enter SSN : ");
            //            emp.SetSSN(int.Parse(Console.ReadLine()));

            //            Console.Write("Enter First Name : ");
            //            emp.SetFname(Console.ReadLine());

            //            Console.Write("Enter Last Name : ");
            //            emp.SetLname(Console.ReadLine());
            //            bool isvaled ;
            //            do {

            //                try
            //                {
            //                    Console.Write("Enter Age : ");
            //                    emp.Setage(int.Parse(Console.ReadLine()));
            //                    isvaled = true;
            //                }
            //                catch (Exception ex)
            //                {
            //                    Console.Write("Re ");
            //                    isvaled = false;

            //                }
            //            } while (!isvaled);


            //            do
            //            {
            //                try
            //                {
            //                    Console.Write("Enter Address : ");
            //                    emp.SetAddress(Console.ReadLine());
            //                    isvaled = true;

            //                }
            //                catch(Exception ex)
            //                {
            //                    Console.Write("Re ");
            //                    isvaled = false;

            //                }
            //            } while (!isvaled);



            //            emp.Print_Data();

            //            break;
            //        case 2:
            //            Console.WriteLine($"Enter number of employee : ");
            //            int ind = int.Parse(Console.ReadLine());
            //            Empoloyee[] emps= new Empoloyee[ind]; 
            //            for(int i = 0; i < emps.Length; i++)
            //            {
            //                Console.Write("Enter SSN : ");
            //                emps[i].SetSSN(int.Parse(Console.ReadLine()));

            //                Console.Write("Enter First Name : ");
            //                emps[i].SetFname(Console.ReadLine());

            //                Console.Write("Enter Last Name : ");
            //                emps[i].SetLname(Console.ReadLine());
            //                bool isvaled2;
            //                do
            //                {

            //                    try
            //                    {
            //                        Console.Write("Enter Age : ");
            //                        emps[i].Setage(int.Parse(Console.ReadLine()));
            //                        isvaled2 = true;
            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        Console.Write("Re ");
            //                        isvaled2 = false;

            //                    }
            //                } while (!isvaled2);


            //                do
            //                {
            //                    try
            //                    {
            //                        Console.Write("Enter Address : ");
            //                        emps[i].SetAddress(Console.ReadLine());
            //                        isvaled2 = true;

            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        Console.Write("Re ");
            //                        isvaled2 = false;

            //                    }
            //                } while (!isvaled2);



            //                //emps[i].Print_Data();

            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invaled choise ");
            //            break;
            //    }
            //}while(true);
            #endregion



            //int[] arr= { 1, 3, 6, 5 };
            //int x = 0, y = 3;

            //swap(ref arr,ref x,ref y );

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}

            //MyMath mat = new MyMath();
            //mat.X = 5;
            //mat.Y = 3;
            //Console.WriteLine(mat.Add());


            //Student std1=new Student();
            //Console.Write("Enter SSN : ");
            //std1.SSN = int.Parse(Console.ReadLine());

            //Console.Write("Enter Name : ");
            //std1.Name= Console.ReadLine();

            //Console.Write("Enter Age : ");
            //std1.Age = int.Parse(Console.ReadLine());

            //Console.Write("Enter Address : ");
            //std1.Address = Console.ReadLine();

            //std1.Print();

            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++) 
            {
                students[i] = new Student();
                Console.Write($"Enter SSN std {i+1} : ");
                students[i].SSN = int.Parse(Console.ReadLine());

                Console.Write($"Enter Name std {i+1} : ");
                students[i].Name = Console.ReadLine();

                Console.Write($"Enter Age std {i+1} : ");
                students[i].Age = int.Parse(Console.ReadLine());

                Console.Write($"Enter Address std {i+1} : ");
                students[i].Address = Console.ReadLine();

            }
            for (int i = 0; i < students.Length; i++) 
            {
                //students[i] = new Student();
                students[i].Print();

            }


        }
    }
    
    
    

    

    }
    #endregion



