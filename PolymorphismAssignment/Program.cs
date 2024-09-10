using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Inside the Main() method, instantiating an Employee object with firstName “Sample” and lastName “Student”.
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            //Calling the SayName() method on the object.
            employee.SayName();

            //Using polymorphism to create an object of type IQuittable.
            //Since the Employee class or object implements the IQuittable interface, we can use polymorphism to
            //create an object of the Employee class and assign it to a variable of the IQuittable interface type

            IQuittable employee1 = new Employee();

            //Calling the Quit() method on the object
            employee1.Quit();
        }
    }
}
