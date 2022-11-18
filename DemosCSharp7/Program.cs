
namespace DemosCSharp72
{
    static class Demo
    {
        public class Person
        {
            public int id;   
            public string? name;
        }
        static void Main(string[] args)
        {
            ////////////////////// ANONYMOUS TYPE \\\\\\\\\\\\\\\\\\\\\\
            ///Anonymous types provide a convenient way to encapsulate a set of read-only 
            ///properties into a single object without having to explicitly define a type first.
            ///
            var res = new { Amount = 456, Message = "I'm an Anonymous type" };

            Console.WriteLine($"{ res.Message} : { res.Amount }");

            /////////////////////////////////////////////////////////////

            ////////////////////// NONYMOUS METHODS \\\\\\\\\\\\\\\\\\\\\\
            /// Anonymous methods are the methods without a name, and can be invoked directly by delegate
            /// 

            //List<Person> list = new List<Person>()
            //{
            //    new Person{id = 1, name = "One"},
            //    new Person{id = 2, name = "two"},
            //    new Person{id = 3, name = "Three"},
            //};

            //var p = list.Find(x => x.id == 1);

            //Console.WriteLine(p.id);


            ///////////////////////////////////////////////////////////////            

            ////////////////////// EXTENSION METHODS \\\\\\\\\\\\\\\\\\\\\\
            /// Extension methods enable you to "add" methods to existing types without creating a new derived type, 
            /// recompiling, or otherwise modifying the original type. Extension methods are static methods, <summary>
            /// Extension methods enable you to "add" methods to existing types without creating a new derived type, 
            /// but they're called as if they were instance methods on the extended type
            /// 

            //int[] ints = { 10, 45, 15, 39, 21, 26,0, 89 };
            //var result = ints.OrderBy(g => g);

            //Console.WriteLine(string.Join(",", result));
            //foreach (var i in result)
            //{
            //    System.Console.Write(i + " ");
            //}


            //////////////////////////////////////////////////////////////////

            //////////// ELVIS OPERATOR  OR CONDITIONAL OPERATOR \\\\\\\\\\\\\

            ///The conditional operator ?:, also known as the ternary conditional operator, 
            ///evaluates a Boolean expression and returns the result of one of the two expressions,

            //var rand = new Random();
            //var condition = rand.NextDouble() > 0.5;
            //Console.WriteLine($"Condition Value: {condition}");

            //int? x = condition ? 12 : null;

            //Console.WriteLine($"Result of consditional Operator: {x}");

            //////////////////////////////////////////////////////////////////////
        }
    }

}