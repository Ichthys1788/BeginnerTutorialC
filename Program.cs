using Code0;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{

    /// <Functions>


    /// </End of Functions>
    public class Program
    {
        private static StringBuilder tf;
        private static StringBuilder stff;

        // <Functions>
        static double Getsum(params double[] nums)
        {
            double sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            return sum;
        }

        static double Getsum2(double x = 2, double y = 2)
        {
            return x + y;
        }
        static double Getsum2(string x = "1", string y = "1")
        {
            double dblyX = Convert.ToDouble(x);
            double dblyY = Convert.ToDouble(y);

            return dblyX + dblyY;
        }
        static void PrintInfo(string name, int zipcode)
        {
            Console.WriteLine("{0} lives in the zipcode {1}", name, zipcode);

        }
        public static double DoDiv(double d, double d2)
        {
            if (d == 0 || d2 == 0)
            {
                throw new System.DivideByZeroException();
            }
            return d / d2;
        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (var item in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, item);
            }
        }

        /// </End of Functions>

        static void PaintCar(CarColor carc)
        {
            Console.WriteLine(" the car was painted {0} with the code {1}", carc, (int)carc);
        }
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Animal cadt = new Animal();

            cat.Setnam("Whiskers");
            cat.Sound = "MEow";
            Console.WriteLine("The cat is name {0} and says {1} ",
                cat.GetName(), cat.Sound);
            cat.Owner = "Derek";
            Console.WriteLine("{0} shelter is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("# of animals : {0} ", Animal.NumOfAnimals);


            //ShapeVariables();
            //Carvarialbes();
            //Time();
            //Stringbuilder();
            //errors();
            //dowhilestuff();
            // stuff();
        }

        private static void ShapeVariables()
        {
            Triangle tria = new Triangle();
            tria.basfe = 20;
            tria.height = 50;
            Console.WriteLine("tria.height : {0} ", tria.Area());
            Triangle tran = new Triangle(10, 10);
            tria.height = tran.height;


            Console.WriteLine("# of animals {0}",
                 Animal.GetNumAnimals());


            Console.WriteLine("Are of Rectangle : {0}",
                ShapeMath.GetArea("Rectangle", 5, 6));
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1) { length = l; width = w; }
            public double Area()
            {
                return length * width;
            }
        }
        struct Triangle
        {
            public double basfe;
            public double height;
            public Triangle(double b = 1, double h = 1) { basfe = b; height = h; }
            public double Area()
            {
                return   (basfe * height)/2;
            }


        }
        private static void Carvarialbes()
            {
                CarColor car1 = CarColor.Orange;
                PaintCar(car1);
            }

            private static void Time()
            {
                DateTime awesomeData = new DateTime(1974, 11, 21);
                Console.WriteLine("Day of the week: {0}", awesomeData.DayOfWeek);
                awesomeData = awesomeData.AddDays(4);
                awesomeData = awesomeData.AddMonths(1);
                awesomeData = awesomeData.AddYears(1);
                Console.WriteLine("New Date : {0}", awesomeData.Date);
                TimeSpan lunchTime = new TimeSpan(12, 30, 0);
                lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
                Console.WriteLine("NewTime: {0}", lunchTime.ToString());
            }

            private static void Stringbuilder()
            {
                StringBuilder sb = new StringBuilder("random text");
                StringBuilder sb1 = new StringBuilder("sdfsf sa sfasdf saf s fasfsdfsaf", 256);

                Console.WriteLine("capacit : {0}", sb1.Capacity);
                Console.WriteLine("Length : {0}", sb.Length);

                sb.AppendLine("\nMore important text");
                CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
                string bestCust = "bob smith";
                stff = sb.AppendFormat(enUS, "Best Customer : {0}", bestCust);
                Console.WriteLine("------------------");
                Console.WriteLine(sb.ToString());
                sb.Replace("important", "Stuff");
                Console.WriteLine("------------------");
                Console.WriteLine(sb.ToString());
                sb.Clear();
                sb.Append("neq");
                sb1.Clear();
                sb1.Append("neq");
                Console.WriteLine(sb.Equals(sb1));
                sb1.Insert(11, "  Thats awedsome");
                Console.WriteLine(sb1);
            }

            private static void errors()
            {
                double num1 = 5;
                double num2 = 0;
                try
                {
                    Console.WriteLine("5 / 0 = {0}",
                    DoDiv(num1, num2));

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("you can't divide by zero");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An Error occurred");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Cleaning");
                }
            }


            void dowhilestuff()
            {
                Random rnd = new Random();
                int secretnumber = rnd.Next(1, 10);
                int no = 0;
                Console.WriteLine("Random num {0}", secretnumber);
                do
                {
                    Console.WriteLine("Enter a number between 1 and 10 :");
                    no = Convert.ToInt32(Console.ReadLine());

                } while (secretnumber != no);
                Console.WriteLine("youi did great ");
            }

            void stuff()
            {
                string[,] custNames = new string[2, 2] { { "bob", "Smddith" },
                {"Sally", "Smith" }};
                Console.WriteLine("MD Value : {0}",
                    custNames.GetValue(1, 0));
                for (int i = 0; i < custNames.GetLength(0); i++)
                {
                    for (int df = 0; df < custNames.GetLength(0); df++)
                    {
                        Console.WriteLine(" {0}", custNames[i, df]);
                    }
                }

                int[] arr = { 1, 2, 3, 354, 243, 232, 4, 5, 7, 23 };
                string stuff = "freach";

                Console.WriteLine("-----------");

                Array.Sort(arr);
                Array.Reverse(arr);

                Console.WriteLine("1 at index : {0}",
                    Array.IndexOf(arr, 4));
                arr.SetValue(0, 3);
                int[] srcArray = { 1, 2, 7 };
                int[] destArray = new int[3];
                int startInd = 1;
                int length = 3;
                Array.Copy(srcArray, startInd, destArray, 0, length);
                PrintArray(destArray, "Copy");
                Console.WriteLine("-----------");

                Array anotherArray = Array.CreateInstance(typeof(int), 10);
                srcArray.CopyTo(anotherArray, 5);
                foreach (var item in anotherArray)
                {
                    Console.WriteLine("CopyTo : {0} ", item);
                }
                int[] numArray = { 1, 2, 3, };
            }
        }
    }
