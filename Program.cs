namespace FirstDayBasics
{

    class Program
    {

        enum Gender
        {
            Male = 1,
            Female = 2,
            Other = 3
        }

        enum Level
        {
            Hard = 1,
            Medium = 2,
            Easy = 3,
            High
        }


        static void Main(string[] args)
        {
            #region  road map
            //language
            //C#
            //Basics
            //OOP
            //C# Advanced optional
            //Linq


            //apps
            //Console
            //desktop application (windows forms)
            //web ( asp.net mvc , asp.net web apis)
            //.net maui , blazor , .net aspire 
            //database , sql server , my sql , oracle , sql language
            //entity framework for talks to sql server from app
            //delegates , lampda expressio , anonymous functions , generics ,  
            #endregion

            #region First Session

            // -**What to Cover:**
            //-Overview of C# and .NET Framework/Runtime.
            //-Installing Visual Studio or any IDE(e.g., VS Code).
            //- Creating your first C# project (console application).
            //- Structure of a C# program (`Main` method, namespaces, etc.).
            //- Writing and running a simple "Hello World" program.
            //- Introduction to comments(`//`, `/* */`).

            #endregion

            #region Second Session

            #region Firs Example

            //Console.WriteLine("pls enter name ");
            //string name = Console.ReadLine();

            //Console.WriteLine("pls enter age ");
            //string age = Console.ReadLine();

            //string ahmedDetails = $" Your name = {name} , age = {age}";
            ////Console.WriteLine(ahmedDetails);

            #endregion

            #region Second Example

            //Console.WriteLine("enter  first number ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter second number ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int total = num1 + num2;
            //Console.WriteLine($"Total = {total}");

            #endregion

            #region Third Example 
            //double num1, num2, TotalAdd, TotalSub, TotalMul, TotalDiv;

            ////Console.WriteLine("enter num1");

            //num1 = Convert.ToDouble(Console.ReadLine());

            ////Console.WriteLine("enter num2 ");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //TotalAdd = num1 + num2;
            //TotalSub = num1 - num2;
            //TotalMul = num1 * num2;
            //TotalDiv = num1 / num2;

            //Console.WriteLine($"Add = {TotalAdd} ,Sub = {TotalSub} ,Mul = {TotalMul} ,Div = {TotalDiv}");
            #endregion

            #endregion

            #region Third Session

            //decimal y = 500;
            //int f = (int)y;
            //Console.WriteLine(y);


            //int x = 8 % 3;

            //Console.WriteLine(x);
            //----------------------------------------------
            //increment & decrement

            //int x = 10;
            //int y = 20;

            ////x++;
            ////x--;

            //x += 5; //x=x+1;
            //x -= 10;//x=x-10;

            //Console.WriteLine(x);
            //----------------------------------------------
            //comparison operators (== , > , < ,!= , >= ,<=)

            //int x, y;

            //x = 10;
            //y = 15;

            // Console.WriteLine(x != y);

            //-------------------------------------------------
            //logical operators (||=>or , && => and , ! => not)

            //---------&&------//
            /*true - true =true
            * false - true =false
            * true - false =false
            * false - false =false
           */

            //---------||------//
            /*true - true =true
            * false - true =true
            * true - false =true
            * false - false =false
           */
            //--------- ! ------//
            /*true  = false
            * false = true
           */

            //x = 10; y = 15;
            //and
            // Console.WriteLine(x < y && x > 5);
            //or
            //Console.WriteLine(x < y || x > 50);
            //not

            //bool question1 = x < y;
            //bool question2 = x == 5;
            //bool answer = question1 || question2;

            ////Console.WriteLine(question1);
            ////Console.WriteLine(question2);
            //Console.WriteLine($"the final result = {answer}");

            ////int x = 2;
            //int y = 3;
            //int z = 5;

            //int result = (x + y) * z;
            //Console.WriteLine("result " + result);

            //() => * / => + -

            #endregion

            #region Fourth Session

            //int number = 95;


            //if (number > 90)
            //    Console.WriteLine("exellent");

            //else if (number > 75)
            //    Console.WriteLine("very good");

            //else if (number > 65)
            //    Console.WriteLine("good");

            //else if (number >= 50)
            //    Console.WriteLine("good");
            //else
            //    Console.WriteLine("fail");


            //string name = "ah";

            //if (name.Length <= 3)
            //    Console.WriteLine("invalid name");

            //if (name.Contains("@"))
            //    Console.WriteLine("invalid name");



            //int degree = 55;

            //switch (degree)
            //{
            //    case 90: Console.WriteLine("excelent"); break;
            //    case 75: Console.WriteLine("very good"); ; break;
            //    case 60: Console.WriteLine(" good"); ; break;
            //    default: Console.WriteLine("fail");break;
            //}


            //loops
            //int i = 1;

            //for (; i < 5; i = i + 1)

            //    Console.WriteLine("hi");

            //int x = 0;
            //while (x > 5)
            //{
            //    Console.WriteLine("hi");

            //    x--;
            //}





            //do
            //{
            //    Console.WriteLine("hi");
            //    x++;
            //} while (x > 5);


            ////1,2,3
            //while (true)
            //{
            //    //connection
            //    //pull data
            //    Console.WriteLine("");
            //}

            //var collection = new List<int> { 1, 2, 3 };

            //foreach (int item in collection)
            //{
            //    Console.WriteLine(item);
            //}


            //----------------------------
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("pls enter your Name =");
                //string Name = Console.ReadLine();
                //Console.WriteLine("pls enter your age =");
                //string age = Console.ReadLine();
                //Console.WriteLine($"your Name is = {Name} , your age is {age}");
            }





            #endregion

            #region Fifth Session 

            //int total = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        total = i + total;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("total =" + total);
            #endregion

            #region Six Session 
            //break & continue
            //nested if
            //nested for loop
            //enum
            //conditional order

            while (true)
            {
                //connect contailer like rabbitmq
                //read messages from container

                // msg
                //msg==null;

                // if (msg == null) continue;
                //process
                //process
                ////process
                //
                break;
            }

            int x = 2, y = 2;

            //if (x == 5)
            //    Console.WriteLine("x==2");



            //Console.WriteLine("always");






            //if (x == y)
            //{
            //    if (x == 5)
            //        Console.WriteLine("x==y and x==2");



            //    else
            //        Console.WriteLine("else");
            //}
            //else Console.WriteLine("else");


            //int counter = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"here is number {i} times of i");

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"here is number {j} times of j");
            //    }

            //}


            //hard=1 , medium=2. easy =3
            int difficult = 1;
            if (difficult == 2)

                if (difficult == 3) ;



            Level l = Level.Hard;

            if (l == Level.Hard)
            {
                int hard = (int)Level.Hard;
                //Console.WriteLine(hard);
            }


            Gender g = Gender.Female;

            if (g == Gender.Male)
            {

            }

            //-------------
            int gender = 2;

            if (gender == 1)
            {

            }
            //

            //conditional operator || ternary operator


            // variable = condion ? 1 : 0 ;

            int number = 10;

            //if (number == 10)
            //{
            //    number += 5;
            //}
            //else
            //{
            //    number += 10;
            //}


            number = number == 10 ? number + 5 : number + 10;
            //Console.WriteLine(number);

            int f = 3;
            bool b = f % 2 == 0 ? true : false;
            //Console.WriteLine(b);


            #endregion

            #region Seven Session 
            //arrays

            int numer;

            //string[] names = new string[3];


            //start from zero
            //0,1,2
            // numbers[0] = 10
            //   // numbers[1] = 10;

            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers.Length);

            const int size = 5;
            //int[] numbers;

            ////int size = Convert.ToInt32(Console.ReadLine());//9

            //numbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = i;
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = new int[] { 1, 2, 3, 4 };

            //Console.WriteLine(numbers.Length);

            //const int k = 5;
            //int[] arr = new int[k];

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int total = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    total += arr[i];
            //}

            //Console.WriteLine(total);

            int counter = 0;

            int rows = 3, coulmns = 3;
            int[,] array = new int[rows, coulmns];

            //rows
            for (int i = 0; i < rows; i++)
            {
                //coulmns
                for (int j = 0; j < coulmns; j++)
                {
                    array[i, j] = counter;

                    counter += 1;
                }

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coulmns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

        }
    }
}

