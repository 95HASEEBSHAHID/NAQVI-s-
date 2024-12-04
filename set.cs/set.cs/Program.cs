//Console.WriteLine("Hello in C#");

//string firstName = "Rubbas";
//string lastName = "Yar Khan";

//Console.WriteLine("Welcome! To our company Mr." + firstName + " " + lastName);

//DATATYPES
//// integer datatypes
//byte age = 23;

//short salary = 32000;

//int number = 786;

//float temp = 32.23F;

//long largeNum = 1221462872143247124L;

//double largeAge = 152.883D;

//decimal deciNum = 9912.341M;

////string datatypes

//char grade =  'A';

//string address = "Aptech north nazimabad";

////bool

//bool isValid = true;

//Arithmetic Operators
//Console.WriteLine(100 + 45);
//Console.WriteLine(100 * 45);
//Console.WriteLine(100 - 45);
//Console.WriteLine(100 / 45);
//Console.WriteLine(100 % 45);

// num = num + 2 || num += 2

//int numb = 6;

//Console.WriteLine(numb += 2); // numb = numb + 2
//Console.WriteLine(numb -= 2);
//Console.WriteLine(numb *= 2);
//Console.WriteLine(numb /= 2);

//Comparision Operator (True or False)

//using System;

//int a = 70; int b = 50;

//Console.WriteLine(a == b); //F
//Console.WriteLine(a > b); //T
//Console.WriteLine(a < b); //F
//Console.WriteLine(a >= b); //T
//Console.WriteLine(a <= b); //F
//Console.WriteLine(a != b); //T

//LOGICAL OPERATORS (AND &&  OR || NOT !)

//AND &&  T  T = T, T  F = F, F  T = F, F F = F 

using System;

//int a = 55, b = 55;

//Console.WriteLine(a >= b && a < b); //F
//Console.WriteLine(b >= a && b > a); //T


//OR || T T = T, T F = T, F  T = T, F  F = F 

//Console.WriteLine(a < b || a == b); //T
//Console.WriteLine(a > b || a >= b); //F

//NOT ! 

//Console.WriteLine(!(a == b)); //TRUE


//Conditional Statements

//Console.WriteLine("Enter salary..");

//int salary = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Your salary is: " + salary);

//if(salary > 50000 && !(salary >= 80000))
//{
//    Console.WriteLine("Good Salary Package");
//}
//else if(salary <= 50000)
//{
//    Console.WriteLine("Do you get fuel allounce..?");

//    string ans = Console.ReadLine();

//    ans = ans.ToLower();

//    if(ans == "yes" ||  ans == "y")
//    {
//        Console.WriteLine("Sounds goods..");

//    }
//    else if(ans == "no" || ans == "n")
//    {
//        Console.WriteLine("Try to switch your job..");
//    }
//    else
//    {
//        Console.WriteLine("Plz enter yes or no..");
//    }
//}
//else
//{
//    Console.WriteLine("MASHALLAH Great!!");
//}

//SWITCH CASE

//Console.WriteLine("Enter number for day.");

//int number = Convert.ToInt32(Console.ReadLine());

//switch (number)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    default:
//        Console.WriteLine("Chutti Day");
//        break;
//}

//String Interpolation
//int a = 56;

//Console.WriteLine($"This number {a} will become 58 after adding 2 {a + 2}");

//Loops
//ForLoop

//for(int i = 0; i <=50; i++)
//{
//      Console.WriteLine(i);
//}


//for (int i = 30; i > 0; i--)
//{
//    Console.WriteLine(i);
//}

//Odd
//for(int i = 1; i <= 100; i++)
//{
//    if(i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}
//Even
//for(int i = 1; i <= 100; i++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//2 x 1 = 2
//num & Limit 

//int num = 2;

//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(num*i);
//}

//int num, temp = 0;

//Console.WriteLine("Enter any number..");

//num = Int32.Parse(Console.ReadLine());

//for(int i = 2; i <= num / 2; i++)
//{
//    if(num % 2 == 0)
//    {
//        temp++;
//        break;
//    }
//}

//if(temp == 0 && num != 1)
//{
//    Console.WriteLine($"{num} is a Prime Number");
//}
//else
//{
//    Console.WriteLine($"{num} is not a Prime Number");
//}


//While Loop

//int num = 40;

//while (num < 100)
//{
//    //Console.WriteLine("Rubbas");
//    Console.WriteLine(num);
//    num++;
//}

////Do While Loop

//int a = 20;
//do
//{
//    Console.WriteLine("a");
//    a++;
//} while (a <= 50);
//int num;
//char ans;
//do
//{
//    Console.WriteLine("Enter any number.");
//    num = Convert.ToInt32(Console.ReadLine());

//    if (num % 2 == 0)
//    {
//        Console.WriteLine("Even Number");

//    }
//    else
//    {
//        Console.WriteLine("Odd Number");
//    }

//    Console.WriteLine("Press Y to continue");
//    ans = Convert.ToChar(Console.ReadLine());

//} while (ans == 'Y' || ans == 'y');

//Array

//int[] numbers = new int[7];

//numbers[0] = 23;
//numbers[1] = 13;
//numbers[2] = 33;
//numbers[3] = 43;
//numbers[4] = 53;
//numbers[5] = 63;
//numbers[6] = 73;


//Console.WriteLine(numbers[5]);

//int[] itemPrice = { 23, 45, 70, 67, 45 };

////Console.WriteLine(itemPrice[3]);
//foreach (var item in itemPrice)
//{
//    Console.WriteLine(item);
//}


//string[] countries = { "Iran", "Iraq", "China", "India", "Pakistan", "UK", "USA", "Saudia Arabia", "Pakistan", "Iran", "Iraq", "China", "India" };

////Sort
////Array.Sort(countries);

////Reverse
////Array.Reverse(countries);

//foreach (var country in countries)
//{
//    Console.WriteLine(country);
//}


////Console.WriteLine(Array.IndexOf(countries, "India"));
//Console.WriteLine(Array.LastIndexOf(countries, "India"));

//Multidimentional Array

//int[,] oldNewPrice =
//{
//    {55, 90 },
//   //00   01
//    {155, 190 },
//   //10    11  
//    {35, 60 },
//   //20   21`
//    {75, 80 },
//    {95, 120 },
//    {205, 390 },
//    {435, 790 }
//};

////Console.WriteLine(oldNewPrice[6,1]);

//for(int i = 0; i < oldNewPrice.GetLength(0); i++)
//{
//    Console.WriteLine($"printing {i + 1}");
//    for (int j = 0; j < oldNewPrice.GetLength(1); j++)
//    {
//        Console.WriteLine(oldNewPrice[i,j] );
//    }
//}


//C# unitialized variables default value is: bool= true, int = 0, string = null

//Console.WriteLine(Math.Pow(3, 3));

////JAGGED ARRAY
////the array in which sub-array size is not fixed

//string[][] skillSet =
//{
//    new string[4] {"HTML", "CSS", "JS", "Bootstrap"},
//    new string[4] {"MySQL", "PHP", "LARAVEL", "AdvJS"},
//    new string[3] {"Angular", "SQL SERVER","C#"},
//    new string[2] {"DART","Flutter"}
//};

//Console.WriteLine(skillSet[2][0]);

//for(int i = 0; i < skillSet.Length; i++)
//{
//    for(int j = 0; j < skillSet[i].Length; j++)
//    {
//        Console.WriteLine(skillSet[i][j]);
//    }
//}


//foreach(var skills  in skillSet)
//{
//    foreach(var skill in skills)
//    {
//        Console.WriteLine(skill);
//    }
//} 


//FUNCTIONS

//return type FunctionName() {body};

//NO RETURN WITH NO PARAMETER

//void Greet()
//{
//    Console.WriteLine("Hey! Welcome to our company..");
//}

////calling
//Greet();

//NO RETURN WITH PARAMETER 

//void Greet(string name)
//{
//    Console.WriteLine($"Hey {name}, Welcome to our company");
//}

////calling
//Greet("Ashar Ahmed");
//Greet("Owais Ahmed");
//Greet("Saad Ahmed");
//Greet("Junaid Ahmed");

//Return without Parameter
//string Greet()
//{
//    return "Hey! Welcome to our company..";
//}

////Greet();
//string messg = Greet();

////Console.WriteLine(Greet());
//Console.WriteLine(messg);

//RETURN WITH PARAMETER
// \n break line
//string empDetails(string empName, byte age)
//{
//    return ($"Employee name is {empName}. \nEmployee age is {age}");
//}

//string messg = empDetails("Jheeetha Laal", 34);

//Console.WriteLine(messg);

//COLLECTIONS
//DSA
//GENERIC COLLECTION
//LIST, STACK, QUEUE, DICTIONARY

//NON GENERIC COLLECTION
//HASHTABLES, ARRAYLIST

//LIST

using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

//List<string> SweetDishes = new List<string>();
//SweetDishes.Add("Rabri");
//SweetDishes.Add("Gollab Jamun");
//SweetDishes.Add("Ras Malai");
//SweetDishes.Add("Custurd");


//List<string> Foods = new List<string>();
//Foods.Add("BBQ");//0
//Foods.Add("Zinger Burger");//1
//Foods.Add("Chicken Cheese Roll");
//Foods.Add("Chicken Steak");//3
//Foods.Add("Beef Steak");
//Foods.Add("Alferado Pasta");
//Foods.Add("Lasagnia");


////Foods.Remove("BBQ");
////Foods.RemoveAt(3);
//Foods.Insert(1, "Chicken Cheese Burger");

////Console.WriteLine(Foods.Contains("BBQ"));
////Console.WriteLine(Foods.Contains("Beef Mandi"));
//Foods.Insert(3, "Beef Mandi");
////Console.WriteLine(Foods.Contains("Beef Mandi"));

//Foods.AddRange(SweetDishes);
//Foods.RemoveRange(0, 4);

//foreach (var food in Foods)
//{
//    Console.WriteLine(food);
//}

//foreach(var swDish in SweetDishes)
//{
//    Console.WriteLine(swDish);
//}

//STACK --> LIFO(Last In First Out) E.g Pile of plates METHODS: PUSH, POP
//Stack<string> Students = new Stack<string>();
//Students.Push("Rubbas");
//Students.Push("Hasnain");
//Students.Push("Faizan");
//Students.Push("Rao Tariq");
//Students.Push("Sameer");
//Students.Push("Saif");

//Students.Pop();//saif
//Students.Pop();//sameer
//Students.Pop();//rao tariq
//Students.Pop();//faizan

//foreach (var student in Students)
//{
//    Console.WriteLine(student);
//}



//QUEUE -->FIFO(First In First Out) E.g Passport Office Line MEthods: Enqueue, Deque
//Queue<string> Cars= new Queue<string>();
//Cars.Enqueue("BMW");
//Cars.Enqueue("Tesla");
//Cars.Enqueue("Accord");
//Cars.Enqueue("Civic");
//Cars.Enqueue("City");

//Cars.Dequeue();//BMW
//Cars.Dequeue();//Tesla


//foreach (var item in Cars)
//{
//    Console.WriteLine(item);
//}

//DICTIONARY
//Dictionary<string, string> user = new Dictionary<string, string>();
//user.Add("username", "Saif");
//user.Add("email", "saif987654321@gmail.com");
//user.Add("password", "saif786");
//user.Add("role", "admin");
//user.Add("image", "saif.jpg");

////Console.WriteLine(user["role"]);

//user.Remove("username");


//foreach (var item in user)
//{
//    string[] test =(item.ToString().Split(','));
//    string key = test[0].Trim('[');//[
//    string value = test[1].Trim(']');//]

//    //Console.WriteLine(key);
//    //Console.WriteLine(value);

//    Console.WriteLine($"The property is:{key} and the value is:{value}");
//}


//NON GENERIC COLLECTION
//HASHTABLES: No fixed datatype

//Hashtable user = new Hashtable();
//user.Add("username", "saif");
//user.Add("email", "saif987654321@gmail.com");
//user.Add("password", 12345);
//user.Add("hasEligibilty", true);
//user.Add("role", "admin");
//user.Add("image", "saif.jpg");

//foreach(DictionaryEntry item in user)
//{
//    Console.WriteLine(item.Key + " : " + item.Value);
//}

//Console.WriteLine(user.GetHashCode());


//ARRAYLIST (No fix datatype)

//ArrayList Cars = new ArrayList();
//Cars.Add("Mehran");
//Cars.Add("City");
//Cars.Add("Civic");
//Cars.Add("Carolla");
//Cars.Add("Accord");
//Cars.Add("BMW");
//Cars.Add("Sportage");
//Cars.Add(580);

//Console.WriteLine(Cars.Count);
//Console.WriteLine(Cars.Contains("BMW"));
//Cars.Remove("BMW");
//Cars.RemoveAt(2);
//Cars.RemoveRange(3, 2);

//foreach (var car in Cars)
//{
//    Console.WriteLine(car);
//}

//String Methods
//string test = "we are Learning \"C#\"";
//Console.WriteLine(test);
//Console.WriteLine(test.Replace("Learning", "Mastering"));
//Console.WriteLine(test.Replace("C#", "Java"));




//CODING Best Practices
// Indentation (Readable by using spaces and new lines) 
// Comments 
// Meaningful identifiers (variable names)
// errors (exception handling) 
//less repeatation

//OOP
//Objects and Classes

//Aeroplane Boeing707 = new Aeroplane();//default constructor


////Boeing707.Name = "Boeing 707";
////Boeing707.takeOff();
////Console.WriteLine(Boeing707.AirLine);

////Aeroplane f16 = new Aeroplane("PAF");
//////Console.WriteLine(f16.Name);
////f16.takeOff();

//Aeroplane f17 = new Aeroplane("PAF", "F-17 Thunder", 3,  2, "8500hp");
//f17.takeOff();
////f17.land();

//public class Aeroplane
//{
//    public string? AirLine;
//    public string? Name;
//    public int Seats;
//    public int Crew;
//    public string? Power;

//    //Contstructor
//    public Aeroplane()
//    {
//        this.AirLine = "Not specified";
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//        this.Power = null;
//    }

//    public Aeroplane(string AirLine)
//    {
//        this.AirLine = AirLine;
//        this.Name = "unknown";
//        this.Seats = 0;
//        this.Crew = 0;
//        this.Power = null;
//    }


//    //    //Paremeterized constructor (Overloading)
//    public Aeroplane(string ALine, string name, int seat, int crew, string pow)
//    {
//        this.AirLine = ALine;
//        this.Name = name;
//        this.Seats = seat;
//        this.Crew = crew;
//        this.Power = pow;
//    }
//    public void takeOff()
//    {
//        Console.WriteLine($"{this.Name} is taking off. Best Wishes..!");
//    }
//    public void land()
//    {
//        Console.WriteLine($"{this.Name} is Landing at the 4th runway..! ");
//    }

//}

//OOP (OBJECT ORIENTED PROGRAMMING)
//it is an approach to code cleaner and better.
//readable
//reusable
//optimize
//proper structure of the code is maintained.

//Main Pillars of OOP

//1. Interitance
// i . Single level inheritance  Vehicle -> Car
// ii . Multi level inheritance  Vehicle -> Car -> Ecar
// iii. Heirarchical inheritance Vehicle ->Car , Vehicle-> Bike
// iv. Multiple inheritance  
// v. Hybrid inheritance    Vehicle -> CAR , Vehicle -> Car -> Ecar, Car-> Ecar

//2. Polymorphism
// Method Overloading
// Method Overriding
//3. Abstraction
//4. Encapsulation

//Inheritance
//Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
//abc.Run();

//Car mercedez = new Car("TZ-8908", "Black", "Mercedez", "Benz C-Class", 20000000);
////mercedez.Run();
//mercedez.Run(500);

////// Parent class | Base Class | Super Class
//public class Vehicle
//{
//    public string regNo;
//    public string color;

//    public Vehicle(string regno, string color)
//    {
//        this.regNo = regno;
//        this.color = color;
//    }
//    public void Run()
//    {
//        Console.WriteLine($"{this.regNo} vehicle started running");
//    }
//}
//////// Child class | Derived Class | Sub Class
//public class Car : Vehicle
//{

//    public string brand;
//    public string model;
//    public int price;

//    public Car(string regno, string color, string brand, string model, int price) : base(regno, color)
//    {
//        this.brand = brand;
//        this.model = model;
//        this.price = price;
//    }

//    //method overriding
//    public void Run()
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
//    }
//    //method overloading
//    public void Run(int speed)
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running" +
//            $" at {speed} MPH.");
//    }

//}


//abstract public class Vehicle
//{
//    public string regNo;
//    public string color;

//    public static int totalCars = 0;
//    public static int totalAmount = 0;
//    public static int payingCars = 0;
//    public static int nonPayingCars = 0;
//    public virtual void Run()
//    {
//        Console.WriteLine($"{this.regNo} vehicle started running");

//    }
//}
//abstract public class Car : Vehicle
//{
//    public string brand;
//    public string model;
//    public int price;
//    public int basePrice = 2;
//    public static int carCount = 0;
//    public Car(string regno, string color, string brand, string model, int price)
//    {
//        this.regNo = regno;
//        this.color = color;
//        this.brand = brand;
//        this.model = model;
//        this.price = price;
//        totalCars++;
//        carCount++;
//    }
//    public static void paytax()
//    {
//        Console.WriteLine("Boom..! the race has begun. May the best be winner.");
//        //payingCars++;
//        //totalAmount += this.basePrice;

//    }

//    public void passWithoutPaying()
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
//        nonPayingCars++;
//    }

//    //method overriding
//    public void Run(int speed)
//    {
//        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at " +
//            $"{speed} MPH.");
//    }

//}

//Interfaces
//FrontEndDeveloper ashar = new FrontEndDeveloper();
//ashar.ComplexDesign("Ashar Ahmed");
//ashar.SimpleDesign();

//FullStackDeveloper usama = new FullStackDeveloper();
//usama.SimpleDesign();
//usama.ComplexAPIs();
//usama.Authentication();

////interface topics
////{

////Interfaces,
////        Static,
////       Abstract
////} 
//interface FrontEndDevelopment
//{
//    public void SimpleDesign();
//    public void ComplexDesign(string name);

//}


//interface BackEndDevelopment
//{
//    public void SimpleCrud();
//    public void ComplexAPIs();
//    public void Authentication();

//}

//public class FrontEndDeveloper : FrontEndDevelopment
//{
//    //method implementation
//    public void SimpleDesign()
//    {
//        Console.WriteLine("We will provide you simple and responsive design using HTML, CSS and JS.");
//    }
//    public void ComplexDesign(string name)
//    {
//        Console.WriteLine($"Hi this is {name}, We will provide you animated and responsive design using HTML, CSS, JS, React, " +
//            $"Nextjs.");
//    }

//}



////Multiple Inheritance
//public class FullStackDeveloper : FrontEndDevelopment, BackEndDevelopment
//{
//    public void SimpleDesign()
//    {
//        Console.WriteLine("We will provide you simple and responsive design using HTML, CSS and JS.");
//    }
//    public void ComplexDesign(string name)
//    {
//        Console.WriteLine($"Hi this is {name}, We will provide you animated and responsive design using HTML, CSS, JS, React, Nextjs.");
//    }
//    public void SimpleCrud()
//    {
//        Console.WriteLine("We will provide you simple crud operations.");
//    }
//    public void ComplexAPIs()
//    {
//        Console.WriteLine($"We will provide you complex APIs.");
//    }
//    public void Authentication()
//    {
//        Console.WriteLine($" We will provide you Authentication.");
//    }
//}

//Access  Modifiers
//1. Public     | anyone can access from any where in the program.
//2. Private    | only owner class can access .
//3. Protected  | only owner class and child class can access .

//Products neckBand = new Products(1500, "Lenovo Neckband", "good quality product with extra base and long range connectivity.");
//neckBand.name = "Lenovo Neckband";
//neckBand.price;
//neckBand.description;
//Console.WriteLine(neckBand.price);

//neckBand.showPrice();
//neckBand.callShowPrice();

//Gadgets iphone = new Gadgets(230000, "iphone 15 pro max", "acha phone ha", "mobiles");
//iphone.ShowGadget();

//public class Products
//{
//    public string name;
//    private int price;
//    protected string description;

//    public Products(int price, string name, string description)
//    {
//        this.name = name;
//        this.price = price;
//        this.description = description;
//    }

//    private void showPrice()
//    {
//        Console.WriteLine(this.price);
//    }
//    public void callShowPrice()
//    {
//        this.showPrice();
//    }
//}

//public class Gadgets : Products
//{
//    public string category;

//    public Gadgets(int price, string name, string description, string category) : base(price, name, description)
//    {
//        this.category = category;
//    }

//    public void ShowGadget()
//    {
//        Console.WriteLine(this.name);
//        this.callShowPrice();
//        Console.WriteLine(this.description);
//        Console.WriteLine(this.category);
//        //Console.WriteLine(this.price);

//    }
//}

//Delegates
//Math
//Math.Cos()

//Normal Delegate
//MyMaths.MyMathsDelegate Eval = new MyMaths.MyMathsDelegate(MyMaths.Add);
//Eval(4, 8);

//Multicast Delegate

//MyMaths.MyMathsDelegate MultiEval;
// MultiEval = MyMaths.Mul;
//MultiEval(2, 5);

//MultiEval = MyMaths.Div;
//MultiEval(2, 0);

//MultiEval = MyMaths.Sub;
//MultiEval(2, 0);

//MyMaths.Sub(4, 2);
//public class MyMaths
//{
//    public delegate void MyMathsDelegate(double num1, double num2);

//    public static void Add(double a, double b)
//    {
//        Console.WriteLine(a + b);
//    }
//    public static void Sub(double a, int b)
//    {
//        Console.WriteLine(a - b);
//    }

//    public static void Mul(double a, double b)
//    {
//        Console.WriteLine(a * b);
//    }
//    public static void Div(double a, double b)
//    {
//        if (b != 0)
//            Console.WriteLine(a / b);
//        else
//            Console.WriteLine("Can't divide by zero");
//    }
//}




using System;
//Shopping.GetItem buy;
//buy = Shopping.GetEatables;
//buy("Jam", 550, "Black current jam with great delight");
//public class Shopping
//{
//    // Declare the delegate
//    public delegate void GetItem(string name, int price, string description);

//    // Static method for GetEatables
//    public static void GetEatables(string name, int price, string desc)
//    {
//        Console.WriteLine("You have bought the item {0} at Rs.{1}. {2}", name, price, desc);
//    }

//    // Static method for GetGadgets
//    public static void GetGadgets(string name, int price, string desc)
//    {
//        Console.WriteLine("You have bought the gadget {0} at Rs.{1}. {2}", name, price, desc);
//    }


//    //public static void Main()
//    //{
//    //    GetItem buy = new GetItem(GetEatables);

//    //    buy("Jam", 550, "Black currant jam with great delight");


//    //    buy = new GetItem(GetGadgets);
//    //    buy("Smartphone", 15000, "Latest model with amazing features");
//    //}
//}





//Shopping.GetItem buy;
//buy = Shopping.GetEatables;
//buy("Jam", 550, "Black current jam with great delight");

//public class shopping

//{
//    publc delegate void GetItem(string name, int price, string description);
//    public ststic void GetEatables(string name, int price, string desc);
//    {
//    console.writeline("You have bought estable {0} at Rs.{1}.{2}." , name , price , desc)//placeholder
//    }

//public ststic void GetGadgets(string name, int price, string desc);
//{
//    console.writeline("You have bought estable {0} at Rs.{1}.{2}.", name, price, desc)//placeholder
//    }

//}


//ternary operator
//string greet = (10 >= 10) ? "Good" : "Bad";
//Console.WriteLine(greet);

//string greets = (10 > 10) ? "Good" : "Bad";
//Console.WriteLine(greets);



//Animal Cat = new Animal();

//Cat.Name = "Tom";
//Cat.Age = 10;
//Console.WriteLine("cat name is : + Cat.Name");
//Console.WriteLine("cat age is :   + Cat.Age");


//public class Animal

//{
//    public string? Name { get; set; }
//    private int age;


//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if (value < 10)
//                age = value;
//        }

//        else{
//            age = 10;
//        }



//    }

//}