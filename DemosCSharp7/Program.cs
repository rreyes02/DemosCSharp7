using System.Security.Cryptography.X509Certificates;

namespace DemosCSharp7
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
        public class Shape
        {

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
            //////////// REF RETURNS AND LOCALS \\\\\\\\\\\\\\\\\\\\\\

            //int[] numbers = { 1, 2, 3 };
            //ref int refValue = ref numbers[2];
            //var valueOf = refValue;

            //refValue = 123;
            //Console.WriteLine( string.Join(",", numbers));

            //////////////////////////////////////////////////////
            
            ///////////// LOCAL FUNCTIONS \\\\\\\\\\\\\\\\\\\\

            //var result = LocalFunctions.solve(1, 10, 16);
            //Console.WriteLine(result);

            ///////////////////////////////////////////////////////

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


            /////////////////////////////////////////
            
            //////// PATTERN MATCHING \\\\\\\\\\\
            
            //static void DisplayShape(Shape shape)
            //{
            //    if (shape is Rectangle)
            //    {
            //        var rc = (Rectangle) shape;
            //    }

            //    var rect = shape as Rectangle;
            //    if (rect != null)
            //    {

            //    }
            //    /// On C#7
            //    if (shape is Rectangle r)
            //    {

            //    }

            //    switch (shape)
            //    {
            //        case Circle c:
            //            break;
            //        case Rectangle sq when (sq.width == sq.height):
            //            // Do something
            //            break;
            //    }
            //}

            ///////////////////////////////////////////////////////////////////

            /////////// OUT Example \\\\\\\\\\\\\\\\\
            
            //DateTime date;
            //if (DateTime.TryParse("01/01/2022",out date)) {
            //    Console.WriteLine(date);
            //}
            //// with c#7
            //if (DateTime.TryParse("02/02/2022", out DateTime date2)) {
            //    Console.WriteLine(date2);
            //}
            //Console.WriteLine(date2.DayOfWeek.ToString());

            ////////////////////////////////////////////////////////////////////
        }
    }

}