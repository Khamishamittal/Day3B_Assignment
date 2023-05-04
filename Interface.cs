using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_Assignment
{
     interface IGames
    {
        void Football();
        void Hockey();

    }

     interface IBalls
    {
        void Plastic();
        
    }
    class Cricket : IGames, IBalls
    {
        public void Football()
        {
            Console.WriteLine("best game");

        }
        public void Hockey()
        {
            Console.WriteLine("national Game");
        }

        public void Plastic()
        {
            Console.WriteLine("xxn xkasmnck");
        }
    }
  
    }

