using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Creating an interface called IQuittable
    interface IQuittable
    {
        //defining a void method called Quit().
        //Note no need for the public access modifier as everything in an interface is public anyway.
        void Quit(); 
    }
}
