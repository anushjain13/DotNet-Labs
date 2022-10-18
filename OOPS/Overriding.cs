using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    namespace Oops
    {
        //Objective: Understand overriding
        //Expectation: need a parent class, child class and one function called ChooseCareer()
        //Classes: Parent, child
        //Relationship: child:Parent
        //Properties:none
        //functions: ChooseCareer() in both the classes

        public class Parents
        {
           public virtual void ChooseCareer()
            {

            }
        }

        public class child : Parents
        {
            public override void ChooseCareer()
            {
                Console.WriteLine("I will choose to become a standup comedian");
            }
        }
    }
}
