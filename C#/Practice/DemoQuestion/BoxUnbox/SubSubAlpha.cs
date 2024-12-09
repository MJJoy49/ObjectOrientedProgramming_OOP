using System;
namespace BoxUnbox
{

    public class A
    {
        internal int i = 10;
    }

    public class B : A
    {
        protected internal int j = 20;
    }

    class PrintA
    {
        public PrintA(ref int r)
        {
            r = 60;
        }
        internal int printA;
    }


    class PrintB
    {
        public PrintB(out string o)
        {
            o = "Try harder!";
        }

        protected internal int printB = 5;
    }


    public class Alpha
    {
        protected static string s = "This is a string";

        protected Alpha()
        {
            s += "alpha ";
        }
    }


    class SubAlpha : Alpha
    {
        public SubAlpha()
        {
            s += " sub ";
        }
    }

    

    public class SubSubAlpha : Alpha
    {
        public SubSubAlpha()
        {
            s += "subsub ";
        }
        public static void printI(A a1)
        {
            Console.WriteLine(a1.i);  //----------------------
        }

        public static void printJ(B b1) 
        {
            Console.WriteLine(b1.j);  //------------------------
        }



        public static void Main(String[] args)
        {
            A a = new A();
            a.i = 21;

            B b = new B();
            b.j = 25;

            printI(a);  //  21
            printI(b);  // 25
            printJ(b);  // 25


            Console.WriteLine(s); //------------------- This is a string

            Console.WriteLine("Find the output"); //Find the output
            s = null; // 0
            new SubSubAlpha(); //
            Console.WriteLine(s); //---------------------- This is a string

            PrintA pa = new PrintA(ref a.i); //

            PrintB pb = new PrintB(out s);


            Console.WriteLine("Out output = " + s);//-------------------Out output = Try harder!
            Console.WriteLine("printA = " + pa.printA); //------------printA = 21
            Console.WriteLine("Ref output = " + a.i); //----------Ref output= 21
            Console.WriteLine("printB = " + pb.printB);//--------printB = Try harder!
        }
    }


}
