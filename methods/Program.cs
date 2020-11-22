using System;
using System.Globalization; // ResortPrices_array
using System.Linq;
using System.Collections;
using System.Threading;


namespace methods

{
    class Methods
    {
        static void Main()
        {

            cars C = new cars();
            //Console.WriteLine("\nInternal Collection (Unsorted - IEnumerable,Enumerator)\n");
            //foreach (car c in C)
            //{Console.WriteLine(c.Make + "\t\t" + c.Year);}
            foreach (car c in C)
            {
                string carString = (c.Make + " " + c.Year);
                DisplayStringWithBorder(carString);
            }
            Console.ReadLine();

            foreach (var item in C)
            {
                DisplayStringWithBorder(item.ToString());
            }



            string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
            foreach (var item in animals)
            {
                DisplayStringWithBorder(item.ToString());
                
            }
            MyClass myClass1= new MyClass("string1","string2", 400);
            Console.WriteLine("int1 {0} \nstring1 {1} \nstring2 {2}", myClass1.myClassInt1, myClass1.myClassString1, myClass1.myClassString2);
            Console.ReadLine();

            Array.ForEach(animals, DisplayStringWithBorder);

          
            HelloWorld();
            ///Pinfo();
            

        }






        public class car
        {
            private int year;
            private string make;
            public car(string Make, int Year)
            {
                make = Make;
                year = Year;
            }
            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            public string Make
            {
                get { return make; }
                set { make = value; }
            }
        }//end class



        public class cars : IEnumerator, IEnumerable
        {
            private car[] carlist;
            int position = -1;
            //Create internal array in constructor.
            public cars()
            {
                carlist = new car[6]
                {
                    new car("Ford",1992),
                    new car("Fiat",1988),
                    new car("Buick",1932),
                    new car("Ford",1932),
                    new car("Dodge",1999),
                    new car("Honda",1977)
                };
            }
            //IEnumerator and IEnumerable require these methods.
            public IEnumerator GetEnumerator()
            {
                return (IEnumerator)this;
            }
            //IEnumerator
            public bool MoveNext()
            {
                position++;
                return (position < carlist.Length);
            }
            //IEnumerable
            public void Reset()
            {
                position = 0;
            }
            //IEnumerable
            public object Current
            {
                get { return carlist[position]; }
            }
        }
        public class MyClass 
        {
            public string myClassString1;
            public string myClassString2;
            public int myClassInt1;

            public MyClass(string aMyClassString1, string aMyClassString2, int aMyClassInt1)
            {
                myClassString1 = aMyClassString1;
                myClassString2 = aMyClassString2;
                myClassInt1 = aMyClassInt1;
            }
        }

        public static void DisplayStringWithBorder(string word)
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = word.Length + EXTRA_STARS;
            int x;
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);
            Console.WriteLine();
            Console.WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);
            Console.WriteLine();
        }
        private static void DisplayIntWithBorder(int number)
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = EXTRA_STARS + 1;
            int leftOver = number;
            int x;
            while (leftOver >= 10)
            {
                leftOver = leftOver / 10;
                ++size;
            }
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);
            Console.WriteLine();
            Console.WriteLine(SYMBOL + " " + number + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);
            Console.WriteLine("\n\n");
        }
        /// <summary>
        /// Count the total number of words in a string
        /// </summary>
        public static void WordCount()
        {
            string str;
            int i, wrd, l;

            Console.Write("\n\nCount the total number of words in a string :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
        ///
        ///
        /// 
            l = 0;
            wrd = 1;

            /* loop till end of string */
            while (l <= str.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Total number of words in the string is : {0}\n", wrd);
        }
        ///
        /// count elements in array
        /// 
        public static void CountArray()
        {
            string[] empty = new string[5];
            var totalElements = empty.Count();
            Console.WriteLine(totalElements);

            string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
            totalElements = animals.Count();
            Console.WriteLine(totalElements);

            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
            totalElements = nums.Count();
            Console.WriteLine(totalElements);
        }

        ///
        ///
        /// 

        ///
        /// count returned searches in array
        /// 
        public static void CountSearchArray()
        {
            string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
            var totalCats = animals.Count(s => s == "Cat");
            Console.WriteLine(totalCats);

            var animalsStartsWithA = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(animalsStartsWithA);

            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
            var totalEvenNums = nums.Count(n => n % 2 == 0);
            Console.WriteLine(totalEvenNums);
        }
        ///
        ///
        /// 


        /// <summary>
        /// /////////////////////////////////////////////
        /// </summary>
        private static void HelloWorld()
            {
                Console.WriteLine("Hello World!");
            }

            /// <summary>
            /// ////////////////////////////////////////////
            /// </summary>
            /// <param name="args"></param>
            static void ResortPrices_array()

            {

                int price = 0;
                Console.WriteLine("Please enter the number of days you would like to stay with us:");
                int days = Convert.ToInt32(Console.ReadLine());

                if (days <= 2)
                {
                    price = price + 200;
                }
                else if (days <= 4 && days > 2)
                {
                    price = price + 180;
                }
                else if (days > 4 && days < 8)
                {
                    price = price + 160;
                }
                else if (days > 7)
                {
                    price = price + 145;
                }
                else
                {
                    Console.WriteLine("invalid answer!");
                }

                int total = price * days;
                price.ToString("C", CultureInfo.GetCultureInfo("en-US"));

                //prices for user
                Console.WriteLine(
                    "Nightly rates are \n{0:C} for one or two nights\n{1:C} for three and four nights\n{2:C} for five, six and seven nights\n{3:C} for eight nights or more",
                    200.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                    180.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                    160.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                    145.ToString("C", CultureInfo.GetCultureInfo("en-US")));

                Console.WriteLine("Price per night is {0}.", price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                Console.WriteLine("Total for {0} night(s) is {1}", days,
                    total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                Console.ReadLine();
            }

            /// <summary>
            /// ////////////////////////////////////////
            /// </summary>
            static void CheckZips()
            {
                string[] zips =
                {
                    "12789", "54012", "54481", "54982", "60007",
                    "60103", "60187", "60188", "71244", "90210"
                };
                Console.WriteLine("Enter a Zip code:");
                string user_code = Console.ReadLine();
                bool found = false;

                for (int i = 0; i < 10; i++)
                {
                    if (zips[i] == user_code)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine("Delivery to " + user_code + " ok.");
                }
                else
                {
                    Console.WriteLine("Sorry - no delivery to " + user_code + ".");
                }
            }

            ///
            //////////////////
            /// 
            static void AverageNumber()
            {
                int[] numbers = {12, 15, 22, 88};
                int x;
                double average;
                double total = 0;
                Console.WriteLine("\nThe numbers are...");
                for (x = 0; x < numbers.Length; ++x)
                {
                    Console.WriteLine("{0,6}", numbers[x]);
                }

                Console.WriteLine();
                for (x = 0; x < numbers.Length; ++x)
                {
                    total += numbers[x];
                }

                average = total / numbers.Length;
                Console.WriteLine("The average is {0}", average);
            }

            /// <summary>
            /// test average with deviations
            /// </summary>
            static void AvgTest()

            {
                //array declaration
                int[] testScore = new int[8];

                //variable declaration
                float avg, sum = 0;

                //get user input
                Console.WriteLine("Enter the test score of eight student: ");
                for (int i = 0; i < 8; i++)
                {
                    testScore[i] = Convert.ToInt32(Console.ReadLine());
                    sum = sum + testScore[i];
                }

                //calculate average
                avg = sum / 8;

                //display the result
                for (int i = 0; i < 8; i++)
                {
                    Console.Write("Test # " + i + ": " + testScore[i] + " From average: " + (int) (testScore[i] - avg) +
                                  "\n");
                }



                /////
                ///
                /// dimensional arrays
                ///
                ///
                static void DimensionalArray()

                {
                    // Two-dimensional array.
                    int[,] array2D = new int[,] {{1, 2}, {3, 4}, {5, 6}, {7, 8}};
                    // The same array with dimensions specified.
                    int[,] array2Da = new int[4, 2] {{1, 2}, {3, 4}, {5, 6}, {7, 8}};
                    // A similar array with string elements.
                    string[,] array2Db = new string[3, 2]
                    {
                        {"one", "two"}, {"three", "four"},
                        {"five", "six"}
                    };
                    // Or use the short form:
                    // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

                    // Three-dimensional array.
                    int[,,] array3D = new int[,,]
                    {
                        {{1, 2, 3}, {4, 5, 6}},
                        {{7, 8, 9}, {10, 11, 12}}
                    };
                    // The same array with dimensions specified.
                    int[,,] array3Da = new int[2, 2, 3]
                    {
                        {{1, 2, 3}, {4, 5, 6}},
                        {{7, 8, 9}, {10, 11, 12}}
                    };

                    // Accessing array elements.
                    System.Console.WriteLine(array2D[0, 0]);
                    System.Console.WriteLine(array2D[0, 1]);
                    System.Console.WriteLine(array2D[1, 0]);
                    System.Console.WriteLine(array2D[1, 1]);
                    System.Console.WriteLine(array2D[3, 0]);
                    System.Console.WriteLine(array2Db[1, 0]);
                    System.Console.WriteLine(array3Da[1, 0, 1]);
                    System.Console.WriteLine(array3D[1, 1, 2]);

                    // Getting the total count of elements or the length of a given dimension.
                    var allLength = array3D.Length;
                    var total = 1;
                    for (int i = 0; i < array3D.Rank; i++)
                    {
                        total *= array3D.GetLength(i);
                    }

                    System.Console.WriteLine("{0} equals {1}", allLength, total);

                    // Output:
                    // 1
                    // 2
                    // 3
                    // 4
                    // 7
                    // three
                    // 8
                    // 12
                    // 12 equals 12
                }

                ///
                ///
                ///
                /// foreach array
                ///
                /// 
                static void ArrayForEach()
                {
                    int[] numbers = {4, 5, 6, 1, 2, 3, -2, -1, 0};
                    foreach (int i in numbers)
                    {
                        System.Console.Write("{0} ", i);
                    }

                    // Output: 4 5 6 1 2 3 -2 -1 0
                }
            }

        ///
        /// helper methods
        ///
            private static void Pinfo()
            {
                Console.WriteLine("Personal info");
                Console.WriteLine("What is your first name?");
                string firstname = Console.ReadLine();
                Console.WriteLine("Last Name:");
                string lastname = Console.ReadLine();
                Console.WriteLine("City:");
                string city = Console.ReadLine();
                Console.WriteLine("Age");
                int age = Convert.ToInt32(Console.ReadLine());
            }

            /// <summary>
            /// ///
            /// reverse character
            /// </summary>
            /// <param name="args"></param>
            private static void ReverseChar(string message)
            {
                Console.WriteLine("Input a Message for Reversing:");
                
                char[] messageArray = message.ToCharArray();
                Array.Reverse(messageArray);
                foreach (char item in messageArray)
                {
                    Console.Write(item);
                }

            }
        }

    }


