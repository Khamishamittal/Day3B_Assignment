using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_Assignment
{
    public class Constructors
    {
        public string Name;

        //Non parametrized Constructor
        // It is special method used to initialize objects //It is called when an object of class is created
        //It is used to set initial values for fields.
        // doesnot have return type

        public Constructors()
        {
            Name = "khamisha";

        }
    }
    public class Constructors1

    {
        public string model;
        //Parametrized Constructor
        public Constructors1(string Model)
        {
            model = Model;
        }
    }

    public class Constructors2
    {
        public string Name1;
        public string Name2;
        public Constructors2(string name1 , string name2) {

            Name1 = name1;
            Name2 = name2;
        }
    }

}

