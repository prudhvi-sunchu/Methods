using System.Collections.Generic;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj= new Program(); //object creation
            Program.MethodName();//using static method
            //obj.MethodName();//using instance method
            //int res = Program.Add(2, 6);
            int res = obj.Add(2, 6);
            Console.WriteLine(res);
            Console.ReadLine();
            
        }

        //public void MethodName()
        public static void MethodName()
        {
            Console.WriteLine("This method will not run anything!");
        }
        public int Add(int a, int b) //using instance method
        //public static int Add(int a, int b)//using static method
        {
            int result = a + b;
            return result;
        }
            
    }
}

/*Methods in C#
  A method is a block  of code which only runs when it is called

You can pass data into a method known as parameters.
Method are used to perform certain actions, and  they
are also known as functions.

Method Syntax:

Accessmodifier static void MethodName()
{
}
If we use Void in the Method decleration, it means that
method does not return any thing.

Why Use Mehods

To reuse code: define the code once, and use it many times.

Static KeyWord in method declearation

*/
