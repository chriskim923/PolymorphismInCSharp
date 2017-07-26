using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInCSharp
{
    class Program
    {
        /*
        Static/Compile time polymorphism is achieved by method overloading.
        The compiler knows which overloaded method it is going to call based on the type and
        number of parameters passed on to the method. At compile time, it will give an error if
        there are no methods that match the method signature that is being called.
        */

        public class StaticPolymorphicClass
        {
            public void Add(string a1, string a2)
            {
                Console.WriteLine("Adding Two Strings : " + a1 + a2);
            }

            public void Add(int a1, int a2)
            {
                Console.WriteLine("Adding Two Integers : "+ (a1 + a2));
            }
        }

        /* 
        Dynamic/Runtime polymorphism is achieved by method overriding.
        The compiler would not be aware whether the method is available for overriding
        the functionality or not. So the compiler would not give any error at compile time.
        At runtime, it is decided which method to call. In this example, the compiler only
        requires a virtual Show method. The right version of the Show method cannot be determined
        until the Derived object is initialized.
        */
        public class DynamicBase
        {
            public virtual void Show()
            {
                Console.WriteLine("This is the Base Class method.");
            }
        }

        public class Derived : DynamicBase
        {
            public override void Show()
            {
                Console.WriteLine("This is the Derived Class method.");
            }
        }

        static void Main(string[] args)
        {
            StaticPolymorphicClass staticObject = new StaticPolymorphicClass();
            staticObject.Add("Chris ", "Kim");
            staticObject.Add(5, 10);

            DynamicBase derivedObject = new Derived();
            derivedObject.Show();

            DynamicBase baseObject = new DynamicBase();
            baseObject.Show();
        }
    }
}
