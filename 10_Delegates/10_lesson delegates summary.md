# 10 lesson summary: 
#### 31.12.2018

* namespace can contain: class, enum, delegate and interface. 

### Enum: (enumerated type) -
is keyword to declare an enumeration. 
type that consists of a set of enumerated constants called the enumerator list. 
Usually we dfine it in the namespace, but it can be defined within class or struct. 
by default - the first enumerator has value of 0. 

```csharp
using System;

namespace ConsoleApp5
{

    enum Colors
    {
        red, blue,green,black, white
    }

    enum Day { sun = 1, mod, tue, wed,thu,fri,sat }

    class Program
    {
        static void Main(string[] args)
        {
            Colors c1 = ((Colors)(1));
            Colors c2 = Colors.black;

            Console.WriteLine($"c1 : {c1}, c2: {c2} ");

            // Converting to int type: 
            int day1 = (int)Day.sat;
            int day2 = (int)Day.sun;

            Console.WriteLine($"sat: {day1}, sun: {day2}");

            /* result:
             c1 : blue, c2: black
            sat: 7, sun: 1
            */
        }
    }
}

```
#
### Delegate - type of function:
delegate is a type that safely encapsulating a method. 
the type of the delegate defined by its name. 

##### simple delegate: 
1. define delegate.
2. create function separated from the delegete.
3. create delegate instance, and insert the function to it.
4. call the function through the variable.
```csharp
using System;
namespace ConsoleApp5
{
    delegate void Del(string msg);

    class Program
    {
        static void Main(string[] args)
        {
            Del d = delMethod;
            d("This is my message!");
        }

        public static void delMethod(string msg)
        {
            Console.WriteLine(msg);
        }
    }   
}

```
#
##### in this program: 
1. create delegate
2. create Student class with 2 proc, and one proc of type delegete. 
3. create constructor. 
4. in main class - create array of students, and init it. 
5. create 2 functions - one for each student. 
6. in foreach loop - call each function for each student. 
``` csharp
using System;
namespace ConsoleApp5
{
    delegate void SubjectReaction(string subj);

    class Student
    {
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public SubjectReaction SubjectReactionFunc { get; set; }

        public Student(string studentName, string subject, SubjectReaction subjectReactionFunc)
        {
            StudentName = studentName;
            Subject = subject;
            SubjectReactionFunc = subjectReactionFunc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray =
            {
                new Student("Bob", "Math", BobAction),
                new Student("Alice", "Physics",AliceAction)
            };

            foreach (Student s in studentArray)
            {
                s.SubjectReactionFunc(s.Subject);
            }
        }
        public static void BobAction(string s)
        {
            Console.WriteLine($"my best subject is: {s}");
        }

        public static void AliceAction(string x)
        {
            Console.WriteLine($"I love {x}");
        }
    }
}
```

##### Here we don't create function, we use delegate directly:
```csharp
using System;
namespace _02_Delegates
{
    delegate string sumOf2Numbers(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            sumOf2Numbers[] arr = new sumOf2Numbers[4];
            arr[0] = (int n1, int n2) => { return $"mul of {n1} * {n2} is --> {n1 * n2}"; };
            arr[1] = (int n1, int n2) => { return $"sum of {n1} + {n2} is --> {n1 + n2}"; };
            arr[2] = (int n1, int n2) => { return $"min of {n1} - {n2} is --> {n1 - n2}"; };
            arr[3] = (int n1, int n2) => { return $"div of {n1} / {n2} is --> {n1 / n2}"; };

            foreach(sumOf2Numbers e in arr)
            {
                string res = e(8,6);
                Console.WriteLine(res);
            }
        }
    }
}
```

##### here there is use of concatination. (note: there might be lost of data. )
note: we need to create print and return for each function here. 

```csharp
using System;
namespace _02_Delegates
{
    //a function that gets two int parameters and returns a string
    delegate string ExecAction(int num1, int num2);
    class Program
    {
        static string DivNum(int n1, int n2)
        {
            Console.WriteLine($"div of {n1} and {n2} is {n1 / n2}");
            return $"div of {n1} and {n2} is {n1 / n2}";
        }

        static void Main(string[] args)
        {
            ExecAction action;

            action = (int n1, int n2) => {
                Console.WriteLine($"mul of {n1} and {n2} is {n1 * n2}");
                return $"mul of {n1} and {n2} is {n1 * n2}";
            };

            //when we have in the function's body only one command' we can remove '{return }'
            action += (int n1, int n2) => {
                Console.WriteLine($"sum of {n1} and {n2} is {n1 + n2}");
                return $"sum of {n1} and {n2} is {n1 + n2}";
            };

            //we dont need to write the parameters type - becuse we get it from the delegate decleration
            action += (n1, n2) => {
                Console.WriteLine($"mod of {n1} and {n2} is {n1 % n2}");
                return $"mod of {n1} and {n2} is {n1 % n2}";
            };
            action += DivNum;
            string result = action(4, 2);
            Console.WriteLine("--------------------------Now we print the returned value-----------------------");
            Console.WriteLine(result);
        }
    }
}

```

##### important rules: 
1. we can add many functions to one operand by operator +=
2. we can remove one function using the operator -=
3. when activating operand that consists many functions - they will be activated according to their adding order. 
4. the returned value - will be from the last function. 
5. we can override the last functions when we assing '=' without '+'

```csharp
using System;
namespace _02_Delegates
{
    delegate string ExecAction(int num1, int num2);
    class Program
    {
        static string DivNum(int n1, int n2)
        {
            Console.WriteLine($"div of {n1} and {n2} is {n1 / n2}");
            return $"div of {n1} and {n2} is {n1 / n2}";
        }

        static string MulNum(int n1, int n2)
        {
            Console.WriteLine($"mul of {n1} and {n2} is {n1 * n2}");
            return $"mul of {n1} and {n2} is {n1 * n2}";
        }

        static string SubNum(int n1, int n2)
        {
            Console.WriteLine($"sub of {n1} and {n2} is {n1 - n2}");
            return $"sub of {n1} and {n2} is {n1 - n2}";
        }

        static void Main(string[] args)
        {
            ExecAction action1;

            action1 = DivNum;
            action1 += MulNum;
            action1 += MulNum;
            action1 += SubNum;
            action1 -= DivNum;

            Console.WriteLine("--------------------------action1-----------------------");

            string result = action1(4, 2);

            Console.WriteLine("--------------------------Now we print the returned value (action1)-----------------------");
            Console.WriteLine(result);


            ExecAction action2;

            action2 = DivNum;
            action2 += MulNum;
            action2 += MulNum;
            action2 += SubNum;
            action2 = MulNum;  //--> overriding

            Console.WriteLine("--------------------------action2-----------------------");
            result = action2(4, 2);

            Console.WriteLine("--------------------------Now we print the returned value (action2)-----------------------");
            Console.WriteLine(result);

        }
    }
}

```

###### Create delegate, and use it in class, as proprerty, and function.

```csharp
using System;

namespace _06_Student_action
{
    //step 1 - declare a delegate
    delegate void ActionHandler(string subject);

    class Student
    {
        //step 2 - create a property with the delegate from step 1
        public ActionHandler MorningActions;

        public void WakeUp(string str)
        {
            //step 4 - call to the delegate - via the class
            MorningActions(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            //step 3 - subscribe a function to the event
            student.MorningActions = (s) => { Console.WriteLine($"students says: {s}"); };

            student.WakeUp("I called the class");

            //call direct to the delegate - via the instance
            student.MorningActions("I called the delegate");
        }
    }
}
```

### Event - 
Events enable a class or object to notify other classes or objects when something of interest occurs. The class that sends (or raises) the event is called the publisher and the classes that receive (or handle) the event are called subscribers.
###### Delegate VS Event
Delegate:
* Is to create a type that can point to function
* When we create a delegate in a class:
    * We can call the delegate directly from the instance
    * We can assign into the delegate a new function with `=` (will override all the prev values)
    ######
Events:
* We add this word - before a delegate type property in a class
* When we create an event in a class:
    * We can not call the delegate directly from the instance
    * We can not assign into the delegate a new function with = (only with += or -=)
```csharp
using System;

namespace _06_Student_action
{
    delegate void Del(string str);

    class Student
    {
        public event Del ActionMorning;
        public void wakeup(string str)
        {
            ActionMorning(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ActionMorning += (s) => { Console.WriteLine($"Student say: {s}"); };
            s1.wakeup("I called the class");
        }
    }
}
```
##### If invoke ActionMorning before we addesd functions to it , we will get Unhandled Exception: System.NullReferenceException. So - in this way we are checking that MorningActions is not null
* if we want to check and execute other action if ActionMorning is null we can not use: ActionMorning?.Invoke(str);. and we need to use the long way
```csharp
using System;

namespace _06_Student_action
{
    delegate void Del(string str);

    class Student
    {
        public event Del ActionMorning;
        public void wakeup(string str)
        {
            ActionMorning?.Invoke(str);

            if(ActionMorning == null)
            {
                Console.WriteLine("Sorry, we can't do this event");
            }
        }   
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.wakeup("I called the class");
            s1.ActionMorning += (s) => { Console.WriteLine($"Student say: {s}"); };
            s1.wakeup("I called the class");
        }
    }
}
/* Result:
Sorry, we can't do this event
Student say: I called the class
*/
```
### Generic delegates: 
##### 1. Predicate delegate -  
It represents a method that contains a set of criteria and checks whether the passed parameter meets those criteria or not.
1. Predicate delegate takes one input parameter and boolean return type.
2. Anonymous method and Lambda expression can be assigned to the predicate delegate.

###### simple Predicate: 
1. create function isUpperCase - return bool.
2. create Predicate of type 'string' that = function. 
3. create variable 'res' that will insert string to Predicate. 

```csharp
using System;
namespace _01_Peredicate
{
    
    class Program
    {
        static bool isUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        static void Main(string[] args)
        {
            Predicate<string> isUpper = isUpperCase;
            bool res = isUpper("Hello world");
            Console.WriteLine(res);
        }
    }
}
```
###### Predicate delegate with anonymous method
```csharp
using System;
namespace _01_Peredicate
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool res = isUpper("HELLO");
            Console.WriteLine(res);
        }
    }
}
```
###### Predicate delegate with lambda expression
```csharp
using System;
namespace _01_Peredicate
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = s => s.Equals(s.toUpper());
            bool res = isUpper("HELLO");
            Console.WriteLine(res);
        }
    }
}
```
##### 2. Action delegate -  
Encapsulates a method that has a single parameter and does not return a value.

```csharp
using System;
namespace _01_Peredicate
{
    public delegate void Del(int x);
    class Program
    {
        static void Double(int x)
        {
            Console.WriteLine($"double of {x} is = {x*x}");
        }
        static void Main(string[] args)
        {
            Del d1 = Double;
            d1(3);
        }
    }
}
```

another way to write: (remove delegate declaration.)
```csharp
using System;
namespace _01_Peredicate
{
    class Program
    {
        static void Double(int x)
        {
            Console.WriteLine($"double of {x} is = {x*x}");
        }
        static void Main(string[] args)
        {
            Action<int> a1 = Double;
            a1(3);
        }
    }
}
```
Using Anonymous method with Action delegate:
```csharp
using System;
namespace _01_Peredicate
{
    class Program
    {  
        static void Main(string[] args)
        {
            Action<int> a1 = delegate (int x) { Console.WriteLine($"Double of {x}: {x * x}"); };
            a1(3);
        }
    }
}
```
Using Lambda expression with Action delegate:
```csharp

using System;
namespace _01_Peredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> a1 = x=> Console.WriteLine($"Double of {x}: {x * x}");
            a1(3);
        }
    }
}
```

```csharp
//-------------------Action-------------------
//יש להעביר פרמטרים מופרדים בפסיק -  16- 1 פרמטרים
//the type of the parameter is in the <>
//אבל אי אפשר בשום מצב להחזיר ערך

using System;

namespace _02_Action
{
    delegate void MyAction(int n1, int n2);
    class Program
    {
        static void PrintNum(int num1,int num2)
        {
            Console.WriteLine($"num1:{num1}, num2:{num2}");
        }
        static void Main(string[] args)
        {
            MyAction a0 = PrintNum;
            //a delegate that can ref any function that gets int and returns void
            Action<int,int> a1 = PrintNum;
            a0(1,2);
            a1(1,2);

        }
    }
}
```

##### 3. Func delegate -  
generic delegate that has zero or more input parameters and one out parameter. The last parameter is considered as an out parameter.
1. Func is built in delegate type.
2. Func delegate type must return a value.
3. Func delegate type can have 0-16 input parameters. 
4. does not allow red and out parameters. 
5. can be used with an anonymous method or lambda expression.
``` csharp
using System;
namespace _01_Peredicate
{
    class Program
    {
        static int Sum(int x,int y)
        {
            return x + y;
        }
        static string Mul(int x, int y)
        {
            return $"x * y: {x*y}";
        }
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            int res = add(2, 3);
            Console.WriteLine("Sum: ",res);

            Func<int,int, string> m = Mul;
            string result = m(2, 3);
            Console.WriteLine(result);

        }
    }
}
```
##### Func with Anonymous Method:
```csharp
using System;
namespace _01_Peredicate
{
    class Program
    {     
        static void Main(string[] args)
        {
            Func<int> getRand = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
            int res = getRand();
            Console.WriteLine(res);
        }
    }
}
```
##### Func with lambda expression:
```csharp
using System;
namespace _01_Peredicate
{
    class Program
    {     
        static void Main(string[] args)
        {
            Func<int> getRand = () => new Random().Next(1, 100);
            int res = getRand();
            Console.WriteLine(res);

            // another expample:
            Func<int, int, int> Sum = (x, y) => x + y;
        }
    }
}
```
#### Example of events in Car class:
```csharp
using System;
namespace _01_Peredicate
{

    class Car
    {
        private int gasCounter;
        public event Action<double, int, int> HandleGas;
        public int GasPerKm { get; set; }

        public Car(int gasPerKm)
        {
            GasPerKm = gasPerKm;
        }

        public void  AddGas(int amount)
        {
            if (amount > 0)
                gasCounter += amount;
        }

        public void StartDrive(double km)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Starting to drive: {km} km, gasCounter: {gasCounter}");
            HandleGas?.Invoke(km, gasCounter, GasPerKm);
            gasCounter -= (int)(km * GasPerKm);
        }
    }

    class Program
    {     
        static void Main(string[] args)
        {
            Car c1 = new Car(5);
            c1.AddGas(180);
            c1.HandleGas += (km, amount, gasPerKm) =>
            {
                if (km * gasPerKm > amount)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Car 1 - You dont have gas!!!");
                }
            };

            c1.StartDrive(20);
            c1.StartDrive(80);

            Car c2 = new Car(3);
            c2.AddGas(10);
            c2.HandleGas += (km, amount, gasPerKm) =>
            {
                if (km * gasPerKm > amount)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Car 2 - You dont have gas!!!");
                }
            };
            c2.StartDrive(20);


        }
    }
}
```
