using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public struct Cloud
        {
            public int location, range;

            public Cloud(int loc, int r)
            {
                location = loc;
                range = r;
            }
        }

        public struct Town
        {
            public int location, population;

            public Town(int loc, int pop)
            {
                location = loc;
                population = pop;
            }
        }

        static void Main(string[] args)
        {

            Cloud cloud1 = new Cloud();
            Town town1 = new Town();

            cloud1.location = 13;
            cloud1.range = 2;

            town1.location = 15;
            town1.population = 300;

            Console.WriteLine("Cloud 1 is at {0} and range {1}", cloud1.location, cloud1.range);
            Console.WriteLine("Town 1 is at {0} with population of {1}", town1.location, town1.population);
        

        }



    }
}
