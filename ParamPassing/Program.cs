using System;

namespace ParamPassing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 10, y = 20;
            Add( 100,  200);

            int sum = Add( x,out y);

            Point p1 = new Point();
            p1.X = 10; p1.Y = 10;

            Point p2 = new Point();
            p2.X = 10; p2.Y = 10;

            Point p4 = null;
            //Add(new Point() { X=5, Y= 5}, new Point() { X = 5, Y = 5 });
           Point p3 =  Add(p1, p2);

            int px = Add(p1.X, p1.Y);
            int res;
            bool re = int.TryParse("10", out res);


            Point p5 = Add(ref p4, out p4);


            //// p1.x ?? p1.y ??? p2.x 10 p2.y 10 p3.x 20 p3.y 20

        }



        static int Add( int x, out int y)
        {
            y = 10;

            x++;
            y++;

            return x + y;
        }

        static int Add(ref int x, ref int y)
        {

            x++;
            y++;

            return x + y;
        }

        static int Add(int x, int y)
        {

            x++;
            y++;

            return x + y;
        }

        static Point Add(Point p1, Point p2)
        {

            Point p3 = new Point();
            p3.X = p1.X + p1.Y;
            p3.Y = p1.Y + p2.Y;

            p1.X = 20; p1.Y = 20;
            p2 = new Point();
            p2.X = 20; p2.Y = 20;
            return p3;
        }


        static Point Add( ref Point p1, out Point p2)
        {


            p2 = new Point();
            p2.X = 20; p2.Y = 20;
            Point p3 = new Point();
            p3.X = p1.X + p2.Y;
            p3.Y = p1.Y + p2.Y;

            p1.X = 20; p1.Y = 20;
            return p3;
        }
    }
}
