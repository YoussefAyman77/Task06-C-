using System;
using System.Xml.Linq;
namespace task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Porblem1
            //Point p1 = new Point();
            //Point p2 = new Point(3,4);
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());

            ////why structs unlike class doesn't allow inheritance?
            ////structs are value stored in the stack unlike classes which stored in the heap.
            #endregion

            #region Problem2
            //TypeA t1=new TypeA();
            ////Console.WriteLine(t1.F); private field can't be accessed outside the class
            //Console.WriteLine(t1.G); //protected field can be accessed within the same project
            //Console.WriteLine(t1.H); //publice field can be accessed anywhere
            ////access modifires determine where we can access the members of a class , and who can see them.
            #endregion

            #region Problem3
            //Employee E1 = new Employee(7, "Youssef", 32000);
            //Console.WriteLine(E1.ToString());
            //E1.setEmpName("Sab3awy");
            //E1.EmpID = 17;
            //Console.WriteLine(E1.ToString());
            ////encapsulation is critical because it helps to protect the internal state of an object
            ////and only allow access to it through well-defined interfaces.
            #endregion

            #region Problem4 & Prblem5
            //StrPoint P1 = new StrPoint(3);
            //StrPoint p2 = new StrPoint(3, 4);
            //StrPoint p3 = new StrPoint();
            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(p2.ToString());
            //Console.WriteLine(p3.ToString());
            ////constructors in structs are used to initialize the fields of the struct when an instance is created.
            ////Tostring method improves the readability of the output when we print the struct instance
            ////as it provides our own representation of the structs data 
            #endregion

            #region Part02
            //copy constructor is a constructor that creates a new object as a copy of an existing object.
            //public Person(string name, int age)
            //{
            //     Name = name;
            //     Age = age;
            //}

            //// Copy constructor
            //public Person(Person p)
            //{
            //    Name = p.Name;
            //     Age = p.Age;
            //}
            //Person p1 = new Person("Alice", 25);

            //  // Use copy constructor
            //Person p2 = new Person(p1);
            //---------------
            //indexer is a special type of property that allows you to access elements in a class or struct using a syntax like the array.
            //class EmployeeList
            //{
            //private string[] employees = new string[5];

            //// Indexer
            //public string this[int index]
            //{
            //    get { return employees[index]; }
            //    set { employees[index] = value; }
            //}
            //}
            //EmployeeList list = new EmployeeList();

            //// Using the indexer
            //list[0] = "Sab3awy";
            //Console.WriteLine(list[0]);


            //private → accessible only inside the same class
            //protected → accessible inside class and derived classes
            //internal → accessible inside the same project/assembly
            //public → accessible everywhere
            //protected internal → accessible in derived classes OR same assembly
            //private protected → accessible in derived classes within same assembly
            //class → defines a reference type
            //struct → defines a value type; lightweight; no parameterless constructor allowed
            //this → refers to the current object; used in indexers and methods
            //new → creates an object instance or hides base class member
            //override → overrides a virtual method in derived class
            //virtual → allows a method to be overridden

            #endregion
        }
    }
}
