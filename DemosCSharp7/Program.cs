using System.Security.Cryptography.X509Certificates;

namespace DemosCSharp72
{
    public class LocalFunctions
    {
        public static Tuple<double, double> solve(double a, double b, double c) {
            //double calculate(double x, double y, double z) 
            //{
            //    return y * y - 4 * x * z;
            //}

            // var disc = calculate(a, b, c);
            var disc = calculate();
            var rootD = Math.Sqrt(disc);
            return Tuple.Create(
                    (-b-rootD) / (2*a),
                    (-b+rootD)/(2*a)
                );
            // calling lambda function local without parameters
            double calculate() => b * b - 4 * a * c;
        }
    }
    public class Point
    {
        public int x, y;
        //public void Deconsctruct(out int x, out int y)
        //{
        //    x = x;
        //    y = y;
        //}
    }
    static class Demo
    {
        public class Person
        {
            public int id;   
            public string? name;
        }

        public class Rectangle : Shape
        {
            public int width, height;
        }

        public class Circle : Shape
        {
            public int x, y;
        }
        static Tuple<double, double> sumAndProduct(double a, double b)
        {
            return Tuple.Create(a + b, a - b);
        }
        // Tuple on C#7
        static (double sum, double product) newSumAndProduct(double a, double b)
        {
            return (a + b, a - b) ;
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

            ///////////// DECOSNTRUCTION \\\\\\\\\\\\\\\\\\\\\\\

            //var me = (name: "Jonh", ege: 123);
            //var (name, ege) = me;

            //Console.WriteLine(name);
            //Console.WriteLine(ege);

            //var myPoint = new Point();
            //var (x, y) = myPoint;
            //Console.WriteLine($"{x}");

            /////////////////////////////////////////////////////

            ////////////// TUPLAS \\\\\\\\\\\\\\\\\

            //var sp = sumAndProduct(5, 5);
            //Console.WriteLine($"sum: {sp.Item1}, product: {sp.Item2}");

            //var sp2 = newSumAndProduct(11, 10);
            //Console.WriteLine($"sum2: {sp2.sum}, product2: {sp2.product}");

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

            //    var rect = shape as Rectangle;
            //    if (rect != null)
            //    {

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