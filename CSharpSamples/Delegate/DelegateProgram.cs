using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.Delegate
{
    public class DelegateProgram : IProgram
    {
        delegate double Function(double x);

        public void Run()
        {
            Function sq = new Function(Square);
            Func<int, int> square = x => x * x; // Lambda expression
            sq += Square;
            sq += (x) => { return x * x; }; // lambda expression similar to what used in LINQ

            Console.WriteLine($"{sq.Invoke(2)}"); 
            Console.WriteLine($"{sq(2)}");

            DelegateTest test = new DelegateTest();

            test.YourFunction += Test_YourFunction;

            test.YourFunction += delegate (double x)
            {
                x = 100;
                Console.WriteLine($"From event {x}");
            };

            test.YourFunction += (double x) =>
            {
                x = 102;
                Console.WriteLine($"From event {x}");
            };

            Test_YourFunction();
            PhotoEditor editor = new PhotoEditor();
            Action<string> actions = (path) => 
            {
                Console.WriteLine(path + "from action 1");
            };
            actions += (path) => 
            {
                Console.WriteLine("From action 2");
            };
            editor.Process($"{this.ToString()}", actions);
        }

        private void Test_YourFunction(double x = 40)
        {
            Console.WriteLine($"From event {x}");
        }

        private double Square(double a)
        {
            return a * a;
        }

    }
}
