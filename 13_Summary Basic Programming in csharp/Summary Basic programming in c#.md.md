# Basic programming in c#:

* Basic input output
    * print line with Console.WriteLine
    * get input with Console.ReadLine
    * string interpolation
```csharp
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // output:
            Console.WriteLine("Enter your name: ");
            // input:
            string name=Console.ReadLine();
            // String interpolation:
            Console.WriteLine($"Your name is: {name}");
        }
    }
}
```
* Basic types (number, boolean, char and string)
```csharp
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------numeric --------

            // 1 byte: 0-255
            byte b = 12;

            // 1 signed byte: -128-127
            sbyte sb = 12;

            // int - 4 byte
            int i = 12;

            // uint unsigned int- 4 byte.
            uint u = 12;

            // long- 8 byte
            long l = 12;

            // unsigned long-8 byte
            ulong ul = 12;


            //----------numeric (מספרים עשרוניים)--------
            double db = 12.4;
            float f = 2.44f;
            decimal dm = 3.55m;  // for prices


            //----------chars-----------------------------
            // 2 byte
            char ch = 'a';

            //----------בוליאני---------------------------
            //can contain only `true` or `false`
            bool bl = true;

            //****************ref type********************
            string s = "Hello";
        }
    }
}
```
* Convert Number to String & String to Number
```csharp
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // One way - explicit convertion:
            int num1 = Convert.ToInt32("32");
            string str1 = Convert.ToString(21);

            // Second way- only for number to string:          
            str1 = num1.ToString();
        }
    }
}
```
* implicit and explicit casting
```csharp
using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //----------numeric (מספרים שלמים)---------

            // 1 byte - from 0 to 255
            byte b = 12;

            // 4 byte
            int i = 12;

            // 8 byte
            long l = 12;



            //----------numeric (מספרים עשרוניים)--------
            double d = 12.4;
            float f = 2.44f;
            decimal dm = 3.55m;

            //----------------המרה מרומזת------------
            //המרה מרומזת תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר
            //כל עוד אין חשש שנאבד במהלך ההמרה שום מידע 

            //byte to int
            i = b;
            //byte to long
            l = b;
            //byte to double
            d = b;
            //byte to float
            f = b;
            //byte to decimal
            dm = b;
            //int to long
            l = i;
            //int to double
            d = i;
            //int to float
            f = i;
            //int to decimal
            dm = i;
            //long to double
            d = l;
            //long to float
            f = l;
            //long to decimal
            dm = l;

            //----------------המרה מפורשת------------
            //המרה מפורשת תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר
            //ויש חשש שנאבד במהלך ההמרה שום מידע 

            //int to byte
            b = (byte)i;
            //long to byte
            b = (byte)l;
            //long to int
            i = (int)l;
            //double to byte
            b = (byte)d;
            //double to int
            i = (int)d;
            //double to long
            l=(long)d;
            //double to float
            f = (float)d;
            //double to decimal
            dm = (decimal)d;
        }
    }
}
```
* Array and Matrix

```csharp
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 way: declare size in init, witout cale's value.
            int[] arr1 = new int[3];
            arr1[0] = 2;
            arr1[1] = 3;
            arr1[2] = 4;

            int[][] matrix1 = new int[2][];
            matrix1[0] = new int[] { 1, 2, 3, 4, 5 };
            matrix1[1] = new int[] { 1, 2, 3, 4, 5 };

            // 2 way: declare size, and values in init
            int[] arr2 = new int[3] { 1,2,3};

            int[][] matrix2 = new int[2][] { new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 } };

            // 3 way: declare only values, without size.
            int[] arr3 = new int[] { 2, 3, 4 };

            int[][] matrix3 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 } };

            // print:
            for(int i=0;i<arr1.Length;i++)
                Console.WriteLine(arr1[i]+" ");

            foreach(int[] i in matrix1)
                foreach(int j in i)
                    Console.Write(j);
            Console.WriteLine();           
        }
    }
}

```
* jagged array 
```csharp
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[4] { 1, 2, 3, 4 };
            jagged[1] = new int[3] { 1, 2, 3 };
            jagged[2] = new int[2] { 1, 2 };

            foreach (int[] i in jagged)
            {
                foreach (int j in i)
                    Console.Write(j);
                Console.WriteLine();
            }

        }
    }
}
```
* Conditions- three options to craete a condition 
```csharp
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int num = 7;

            // 1. when using boolean - no need to use == 
            if (flag)
                //if "flag" contains "true"
                Console.WriteLine("flag is true");           
            else
                //if "flag" contains "false"
                Console.WriteLine("flag is false");
            
            // (!flag) is equal to (flag==false)
            if (!flag)
            {
                //if "flag" contains "false"
                Console.WriteLine("flag is false");
            }
            else
            {
                //if "flag" contains "true"
                Console.WriteLine("flag is true");
            }


            // 2. expression that returns boolean value:
            if (num < 8)
            {
                //if num<8
                Console.WriteLine($"num {num} is lt 8");

            }
            else
            {
                //if num is not smaller than 8
                Console.WriteLine($"num {num} is gt 8");
            }


            // 3. with bool value: 
            if (true)
            {
                Console.WriteLine("I am true");

            }
            else // will never run...
            {
                Console.WriteLine("I am false");
            }

        }
    }
}
```


* else-if and nested condition 
```csharp
using System;

namespace _01_nested_conduition
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 7;
            bool IsWinePerson = false;

            if(age<0 || age > 120)
            {
                // "age" < 0   OR  "age" > 120
                Console.WriteLine("Invalid age!!!!");
            }
            else if (age < 25)
            {
                // "age" >= 0   AND   "age" < 25
                Console.WriteLine("You can only drink soft drink");
            }
            else
            {
                // "age" >= 25   AND   "age" <= 120

                //------------nested condition-(תנאי בתוך תנאי)------------
                if (IsWinePerson)
                {
                    Console.WriteLine("You can drink wine!!!");
                }
                else
                {
                    Console.WriteLine("You can drink beer");
                }
            }
        }
    }
}
```


* short condition 
```csharp
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2,c;
            c=(a > b) ? c = a : c=b;
        }
    }
}
```

* Switch - case
```csharp
using System;

namespace _04_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = 6;

            //if there is value inside case - must add 'break' 
            switch (num)
            {
                case 1: Console.WriteLine("I am 1"); break;
                case 2: Console.WriteLine("I am 2"); break;
                default:
                    Console.WriteLine("not 1 or 2");
                    break;
            }

            // if there is no value inside case- it will till the next break
            switch (num)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 5:
                case 6:
                case 7: Console.WriteLine("Weekend"); break;
                default:
                    Console.WriteLine("not Sunday or Monday");
                    break;
            }
        }
    }
}
```

* switch-case - another example:
```csharp
using System;

namespace _05_switch_case___for_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[] { 100, 90, 83, 64, 53, 20 };
            foreach (int grade in grades)
            {
                Console.WriteLine($"----------grade : {grade}-------------------");
                switch (grade / 10)
                {
                    case 10:
                    case 9: Console.WriteLine("Perfect"); break;
                    case 8: Console.WriteLine("Very good"); break;
                    case 7:
                    case 6: Console.WriteLine("Good"); break;

                    default:
                        Console.WriteLine("Try to improve");
                        break;
                }
            }           
        }
    }
}
```

* summarize of operators and short condition
```
* Unary operator: ++x, x++, --x, x--, !x
* Binary operator: a+b, a-b, a/b , a*b, a%b, a||b, a&&b
* Trinary operator: (a)?b:c
```
* while + do-while + for 
```csharp
using System;

namespace _06_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 4;
            Console.WriteLine("-------------while------------------");
            int whileCounter = 0;
            while (whileCounter < limit)
            {
                Console.WriteLine(whileCounter);
                whileCounter++;
            }
            Console.WriteLine("------------do-while------------------");
            int doCounter = 0;
            do
            {
                Console.WriteLine(doCounter);
                doCounter++;
            } while (doCounter < limit);
            Console.WriteLine("-------------for------------------");
            for (int forCounter = 0; forCounter < limit; forCounter++)
            {
                Console.WriteLine(forCounter);
            } 
        }
    }
}
```

* Function- declare function + get parameters + return value 
```csharp
using System;

namespace _08_functions
{
    class Program
    {

        static void Main(string[] args)
        {
            PrintHello();
            PrintSum(3, 4);

            string str = GetHello();
            Console.WriteLine($"Got from GetHello: {str}");

            int num = GetSum(2,5);
            Console.WriteLine($"Got from GetSum: {num}");
        }

        //function that does not get parameters and does not return value
        static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        //function that gets parameters and does not return value
        static void PrintSum(int num1,int num2)
        {
            Console.WriteLine($"{num1}+{num2}={num1+num2}");
        }

        //function that does not get parameters and does return value
        static string GetHello()
        {
            return "Hello";
        }
        //function that gets parameters and does return value
        static int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }      
    }
}
```
* Ref
```csharp
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 4;
            replace(ref a, ref b);
        }
        static void replace(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
```
* enum
```csharp
using System;
namespace test
{   
    enum Color{RED, GREEN, BLUE}
    class Program
    {
        static void Main(string[] args)
        {
            Color C1 = Color.RED;
            Console.WriteLine(C1);  //--> RED
            
            Color C2 = (Color)(1);
            Console.WriteLine(C2); //--> GREEN
        }
    }
}
```
