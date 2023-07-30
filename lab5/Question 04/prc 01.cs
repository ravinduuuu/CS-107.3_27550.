using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Helper
{
    private void sayHello()
    {
        Console.WriteLine("Hello, World!");
    }

    public void CallSayHello()
    {
        sayHello(); // This method can access the private sayHello() method within the same class.
    }
}



class Program
{
    static void Main(string[] args)
    {
        Helper helper = new Helper();
        // helper.sayHello(); // This line will cause a compilation error since sayHello() is a private method and cannot be accessed from outside the Helper class.

        helper.CallSayHello(); // This line will work fine, as CallSayHello() can access the private sayHello() method within the Helper class.
    }
}
