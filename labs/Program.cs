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

            #region Delegates
            calculator(2, 3, Add);

            static void calculator(int x1, int y1, del de)
            {
                int x = de(x1, y1);


                Console.WriteLine($"Add = {x}");

            }
            static int Add(int x = 2, int y = 3)
            {
                return x + y;
            }
            static int Sub(int x, int y)
            {
                return x - y;

                Student[] students = new Student[3];
                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = new Student();
                    Console.Write($"Enter SSN std {i + 1} : ");
                    students[i].SSN = int.Parse(Console.ReadLine());

                    Console.Write($"Enter Name std {i + 1} : ");
                    students[i].Name = Console.ReadLine();

                    Console.Write($"Enter Age std {i + 1} : ");
                    students[i].Age = int.Parse(Console.ReadLine());

                    Console.Write($"Enter Address std {i + 1} : ");
                    students[i].Address = Console.ReadLine();

                }
                for (int i = 0; i < students.Length; i++)
                {
                    //students[i] = new Student();
                    students[i].Print();

                }

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
            }
            public void SetAddress(string address)
            {
                if (address == "cairo" || address == "alex" || address == "giza")
                {
                    this.Address = address;

                }
                else
                {
                    throw new Exception("invaled address");
                }
            }

            public int GetSSN()
            {
                return this.SSN;
            }
            public string GetFname()
            {
                return this.Fname;
            }
            public string GetLname()
            {
                return this.Lname;
            }
            public int GetAge()
            {
                return this.Age;
            }
            public string GetAddress()
            {
                return this.Address;
            }

            public void Print_Data()
            {
                Console.WriteLine($"Employee SSN : {SSN}\nEmpolyee First Name : {Fname}\nEmployee Last Name : {Lname}\nEmpolyee Age : {Age}\nEmployee Address : {Address}");
            }



        }
        #endregion

    }
}
