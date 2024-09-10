using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Creating another class called Employee that inherits from the Person class.
    //Having the Employee class from the previous drill inherit the IQuittable interface by adding a comma and
    //the name of the interface after the Base Class name.
    //This way the Employee class implements the IQuittable interface.
    public class Employee : Person, IQuittable
    {
        //Implementing the SayName() method inside of the Employee class.
        //In order to satisfy the requirement of the abstract SayName() method in the BASE CLASS (Person class),
        //we will define the SayName() method in the Employee class with the "override" keyword.

        public override void SayName()
        {
            Console.WriteLine("Your name is " + firstName + " " + lastName);
            Console.ReadLine();
        }
        //Implementing the Quit() method in a way of my choosing.
        //Here the Employee class overrides all the members of the IQuittable interface with the public access modifier.
        //Notice how the Employee class can also contain members other than the Intferface members.
        public void Quit()
        {
            Console.WriteLine("THIS IS THE BODY OF THE Quit() FUNCTION!");
            Console.ReadLine();
        }
    }
}
