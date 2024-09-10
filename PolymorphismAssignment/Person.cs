using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Creating an ABSTRACT/BASE class called Person with two properties: string firstName and string lastName.
    //Abstract classes can only be INHERITED FROM but can NEVER BE INSTANTIATED.
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Giving it the method SayName().
        //All persons should have their own SayName() method, but we CANNOT define the implementation in the abstract class.
        //Might need to add bespoke features for specific persons
        //To achieve the objective, we have to add an ABSTRACT SayName() method.
        //The abstract method ony exists inside of an abstract class and contains NO IMPLEMENTATION.

        public abstract void SayName();

        //All the abstract method does is state that any method inheriting this class must implement the SayName() method.
        //The inheriting class will then define the SayName() method somewhere in its class with the exact same name and
        //return type and take exactly the same parameters

        //In order to satisfy the foregoing requirement, the SayName() method in the Employee class will have to be
        //defined with the "ovveride" keyword.       
    }
}
