//write a program to print hello world
// Console.WriteLine("Hello, World!");

// write a program to declare different type of variable and print them 
/*int age = 10;
double sal = 550005.5;
bool isemployee = false;
char grade = 'A';
string name = "lalit";


Console.WriteLine("age is "+ age);
Console.WriteLine("sal is "+ sal);
Console.WriteLine("is employeee:"+ isemployee);
Console.WriteLine("grade  is:"+ grade);
Console.WriteLine("name  is:"+ name);*/

// Write a program  to read name and age and print them 
/*Console.WriteLine("Enter your name");
string name = Console.ReadLine(); 

Console.WriteLine("Enter your age");
string age = Console.ReadLine();
greeting obj = new greeting(name, age);

class greeting { 
     public greeting(string name, string age)
    {
        Console.WriteLine("hello my name is :"+ name+" and i am " + age);

    }
}*/



//Write a programto take int input from user and find if the given number is even or odd
/*Console.WriteLine("Enter a number");
string num = Console.ReadLine();
int a = int.Parse(num);
if(a% 2 == 0)
{
    Console.WriteLine("Given number is even.");
}
else
{
    Console.WriteLine("Given number is odd.");
}*/



//Write a program to show the implimentation of switch
/*Console.WriteLine("Select a food item 1.Momo\n 2.Dry Noodles\n 3.Pizza\n 4.kabab");
string Food = Console.ReadLine();
switch(Food)
{
    case "Momo":
        Console.WriteLine("Here is your Momo.");
        break;
    case "Dry Noodles":
        Console.WriteLine("Here is your Dry Noodles.");
        break;
    case "Pizza":
        Console.WriteLine("Here is your Pizza.");
        break;
    case "kabab":
        Console.WriteLine("Here is your kabab.");
        break;
    default:
        Console.WriteLine("East and west momo is best, so here is you Momo.");
        break;  

}*/



//Write a program to show the implimentation of different type of loop the loop through array
/*int[] ints = new int[] {1,2,3,4,5};
for (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine(ints[i]);
}*/

/*
string[] str = new string[] { "abc", "bcd", "cdc" };
int i  = 0;
do
{
    Console.WriteLine(str[i]);
    i++;
}while (i < str.Length);*/


/*
string[] str = new string[] { "abc", "bcd", "cdc" };
foreach (string str2 in str)
{
    Console.WriteLine(str2);
}*/

/*string[] str = new string[] { "abc", "bcd", "cdc" };
int j = 0;
while(j<str.Length)
{
    Console.WriteLine(str[j]);
    j++;
}*/

//Write a program to implement the class and object and print the properties of the class with help of object
/*

Car obj = new Car();
obj.brand = "BYD";
obj.price = 10000;
obj.year = 1989;
obj.Car_detail(obj.brand,obj.year, obj.price);
class Car()
{
    public string brand;
    public int year;
    public int price;

    public void Car_detail(string brand, int year, int price)
    {
        Console.WriteLine("The car brand is "+ brand);
        Console.WriteLine("The car wass made in " + year);
        Console.WriteLine("The car's price is " + price);
    }
}*/


// Wap to demonstrate the type casting from string to int
/*string num = "123";
int number = int.Parse(num);
Console.WriteLine(number);

string flo = "23.3";
float flo_num = float.Parse(flo);
Console.WriteLine(flo_num);
*/

//wap to create a function to take two integer and return their sum 
/*
static int Sum( int a , int b)
    {
    return a + b;
    }
Console.WriteLine("The sum of two integer is : " + Sum(2,3));
*/


//wap to concatenate two strings and print
/*string str1 = " My name is";
string str2 = " Namrata";
string str3 = str1 + str2;
Console.WriteLine(str3);
*/

//write a program to demonstrate the idea of constructor(default)

/*Cons obj = new Cons();
*//*class Cons
{
    public Cons()
    {
        Console.WriteLine("This is the constructor(default)");
    }
}*//*

Const obj2 = new Const("parametarized");
class Const
{
    public Const(string type)
    {
        Console.WriteLine("This is the constructor(" + type + ").");
    }
}
*/

//demonstrate the concept of inheritance
/*

Car car1 = new Car("BYD", 2019, 1000000);
car1.car_number(1234);
Bike Bike1 = new Bike("CBZ", 2022, 2000000);
Bike1.Bike_number(8234);
class Vechile
{
    public Vechile(string brand, int year, int price)
    {
        Console.WriteLine("");
        Console.WriteLine("The Vechile brand is " + brand);
        Console.WriteLine("The Vechile wass made in " + year);
        Console.WriteLine("The Vechile's price is " + price);
    }
}
class Car : Vechile
{
    public Car(string brand, int year, int price) : base(brand, year, price) { }

    public void car_number(int number)
    {
        Console.WriteLine("The number of this car is :" + number);
    }
}

class Bike : Vechile
{
    public Bike(string brand, int year, int price) : base(brand, year, price) { }

    public void Bike_number(int number)
    {

        Console.WriteLine("The number of this Bike is :" + number);
    }
}
*/

//write a program to demonstrate the ides of method overriding

/*Dog dog1 = new Dog();
dog1.sound();
Cat cat1 = new Cat();
cat1.sound();


class Animal
{
    public virtual void sound()
    {
        Console.WriteLine("This is the base class.");
    }
}
class Dog : Animal
{
    public override void sound()
    {
        Console.WriteLine("This is the child class(Dog)");
    }
}
class Cat : Animal
{
    public override void sound()
    {
        Console.WriteLine("This is the child class(Cat)");
    }
}
*/
// WAP to demonstrate the concept of polymerphism
/*
int a = 1, b = 2, c = 3;
Addition add = new Addition();
add.add();
Console.WriteLine("The sum of a and b is " + add.add(a, b));
Console.WriteLine("The sum of a ,b and c is " + add.add(a, b, c));



class Addition
{
    public int add()
    {
        Console.WriteLine("There is no thing to add");
        return 0;   
    }
    public int add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    public int add(int a, int b, int c)
    {
        int d= a + b + c; 
        return d;
    }
}*/

//write a program to implement the concept of abstract
/*
Bird b1 = new Bird();
b1.display1();
b1.display();
Console.WriteLine("The name of the person is :" + b1.name);
*//*
Animal b2 = new Animal();
b2.display1();*//*   //Cant ctreate object of an abstract class


abstract class Animal
{
    public abstract string name { get; }
    
    public void display()
        {
        Console.WriteLine("This is an abstract class");
    
    }

}

class Bird : Animal {
    public override string name { get; } = "Hari";
    public void display1()
    {
        Console.WriteLine("This is an normal class");

    }

}
*/

//WAP to implement the multiple inheritance using interface
/*
Car car1 = new Car();
car1.stop();
car1.start();
Console.WriteLine("");
Bike Bike1 = new Bike();
Bike1.stop();
Bike1.start();

interface Vehicle
{
    void stop();
    void start();

}

class Car : Vehicle
{
    public void stop()
    {
        Console.WriteLine(" The car stopped");
    }
    public void start()
    {
        Console.WriteLine(" The car started");
    }
}
class Bike : Vehicle
{
    public void stop()
    {
        Console.WriteLine(" The Bike stopped");
    }
    public void start()
    {
        Console.WriteLine(" The Bike started");
    }
}*/

//WAP TO IMPLEMENT COLLECTIONS AND GENERICS TO INITIALIZE ARRAY AND PRINT EACH ITEM 

/*using System.Collections;

ArrayList arra = new ArrayList();
arra.Add(1);
arra.Add(2);
arra.Add("hello");
arra.Add("bye");

for (int i = 0; i < arra.Count; i++)
{
    Console.WriteLine(arra[i]);
}


List<string> lint = new List<string>();
lint.Add("hello");
lint.Add("hi");
lint.Add("h0i");
lint.Add("hioooo");


for (int i = 0; i < lint.Count; i++)
{
    Console.WriteLine(lint[i]);
}*/


//WAP TO IMPLEMENT THE IDEA OF ERROR HANDLING
/*try
{
    int num = int.Parse("hello");
    Console.WriteLine("Parsed number is " + num);

}

catch (FormatException ex)
{
    Console.WriteLine("error:" + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("error exception" + ex.Message);
}*/


//write a program to handle divide by zero exception
/*try
{
    int b = 2;
    int a = 0;
    
    Console.WriteLine("The solution of the problem is  " + b/a);

}

catch (DivideByZeroException ex)
{
    Console.WriteLine("error:" + ex.Message);
}*/

//WAP to show exception handling for listindexoutofrange
/*try
{
    List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
    Console.WriteLine("The element in insex 7 is : " + list[7]);

}

catch (Exception ex)
{
    Console.WriteLine("error:" + ex.Message);
}*/


//WAP to create the class Employee and diaplay employee details.
/*using System.Runtime.InteropServices;

Console.WriteLine("Enter how many employee you wanna add");
string n = Console.ReadLine();
int n1 = int.Parse(n);

for (int i = 0; i < n1; i++)
{
    Console.WriteLine("");
    Console.WriteLine("Enter employee name:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter employee  number:");
    string num = Console.ReadLine();
    int num1 = int.Parse(num);
    Employee obj1 = new Employee(name, num1);
}



class Employee
{
    public Employee(string name, int emp_no)
    {
        Console.WriteLine("Employee name is :"+ name);
        Console.WriteLine("Employee number is :" + emp_no);
    }

}



*/