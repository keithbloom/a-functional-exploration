using System;

namespace Functional.Exploration
{
    
    public class Tester
    {
        public void RunAdd5()
        {
            var add5 = new Adding();
            Console.WriteLine(add5.Add5(10));
        }

        public void Iterating()
        {
            var iterator = new Iterating();

            var result = iterator.Iterator(new[] {2, 4, 8}, iterator.Cubed);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}