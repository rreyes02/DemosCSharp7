
////Console.WriteLine("TEST");
////foo();

////void foo() {
////    Console.WriteLine("Inside FOO");
////}

////public class Person
////{
////    public string firstName;
////    public int NSS { get; init; }
////    private readonly string lastName;

////    public string LastName
////    {
////        get => lastName;
////        init => lastName = value ?? throw new ArgumentNullException(nameof(lastName));
////    }

////    public Person() { }
////    public Person(int nss) { NSS = nss; }

////    public string this[int i]
////    {
////        get { return i > 0 ? lastName : firstName; } 
////        init
////        {
////            if (i > 0) lastName = value; 
////            else firstName = value;
////        }
////    }

////    //public void changeNSS(int nss)
////    //{
////    //    // NSS = nss; // Not allowed with INIT
////    //}
////}
//using System.Runtime.CompilerServices;

//namespace DemosCSharp72
//{

//    public static bool IsLetter(this char c) =>
//            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

//    public static bool IsLetterSeparator(this char c) =>
//        c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or ';' or ',';
//    static class Demo
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Test");
//            object o;
//            int temperature = 98;

//            var feel = temperature switch
//            {
//                < 0 => "Freezing",
//                // and
//                >= 0 and < 20 => "Nice",
//                >= 20 => "Warm"
//            };

//            Console.WriteLine(feel);

//            //if (o is not null)
//            //{

//            //}

//            //// if (!(o is string))
//            //if (o is not string)
//            //{

//            //}


//            // var p = new Person { NSS = 123 };
//            //////////// NULLABILITY ESPLAINED \\\\\\\\\\\\\\\\\\\\\

//            // string_ Nullable<string>
//            // It's still a string, but we need null checks
//            // $"{FirstName} {MiddleName?[0} {LastName}

//            // (null as Person).FullName
//            // warning
//            // (null as Person)!.FullName
//            // no warning -- means trust what I'm doing
//            // (null as Person)!!!!!!1.FullName
//            // also legal
//            // (null as Person)!?.FullName
//            // won't compile
//            ////////////////////////////////////////////////////////

//            //////////////// INDICES AND RANGES //////////////////////////      

//            ////////////////////////////////////////////////////////
//        }
//    }

//}