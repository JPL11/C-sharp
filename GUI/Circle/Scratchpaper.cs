using System;

namespace Scratchpaper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(); p1.setPoint(0, 1);
            Point p2 = new Point(); p2.setPoint(1, 0);
            Point p3 = new Point(); p3.setPoint(1, 1);
            Circle c1 = new Circle(0, 0, 1);
            Circle c2 = new Circle(1, 0, 1);
            Circle c3 = new Circle(2, 0, 1);
            Circle c4 = new Circle(0, 0, 2);
            Circle c5 = new Circle(3, 0, 1);

            // whether pont 1 is on circle 1
            p1.print();
            if (c1.onCircle(p1))
                Console.Write(" is on ");
            else
                Console.Write(" is not on ");
            c1.print();
            Console.WriteLine();

            // whether point 1 is on circle 2
            p1.print();
            if (c2.onCircle(p1))
                Console.Write(" is on ");
            else
                Console.Write(" is not on ");
            c2.print();
            Console.WriteLine();

            // whether point 2 is inside circle 2
            p2.print();
            if (c2.inCircle(p2))
                Console.Write(" is inside ");
            else
                Console.Write(" is not inside ");
            c2.print();
            Console.WriteLine();

            // whether point 2 is inside circle 3
            p2.print();
            if (c3.inCircle(p2))
                Console.Write(" is inside ");
            else
                Console.Write(" is not inside ");
            c3.print();
            Console.WriteLine();

            // whether point 3 is outside of circle 1
            p3.print();
            if (c1.outCircle(p3))
                Console.Write(" is outside ");
            else
                Console.Write(" is not outside ");
            c1.print();
            Console.WriteLine();

            // whether point 3 is outside of circle 2
            p3.print();
            if (c2.outCircle(p3))
                Console.Write(" is outside ");
            else
                Console.Write(" is not outside ");
            c2.print();
            Console.WriteLine();

            // whether two circles intersect
            c2.print();
            if (c1.intersect(c2))
                Console.Write(" intersects ");
            else
                Console.Write(" does not intersect ");
            c1.print();
            Console.WriteLine();

            // whether two circles intersect
            c3.print();
            if (c1.intersect(c3))
                Console.Write(" intersects ");
            else
                Console.Write(" does not intersect ");
            c1.print();
            Console.WriteLine();

            // whether two circles are tangent on the outside
            c3.print();
            if (c1.tangentOut(c3))
                Console.Write(" is tangent outside ");
            else
                Console.Write(" is not tangent outside ");
            c1.print();
            Console.WriteLine();

            // whether two circles are tangent on the outside
            c2.print();
            if (c1.tangentOut(c2))
                Console.Write(" is tangent outside ");
            else
                Console.Write(" is not tangent outside ");
            c1.print();
            Console.WriteLine();

            // whether two circles are tangent on the inside
            c2.print();
            if (c4.tangentIn(c2))
                Console.Write(" is tangent inside ");
            else
                Console.Write(" is not tangent inside ");
            c4.print();
            Console.WriteLine();

            // whether two circles are tangent on the inside
            c3.print();
            if (c4.tangentIn(c3))
                Console.Write(" is tangent in ");
            else
                Console.Write(" is not tangent in ");
            c4.print();
            Console.WriteLine();

            // whether two circles are disjointed
            c5.print();
            if (c1.disjoint(c5))
                Console.Write(" is disjointed from ");
            else
                Console.Write(" is not disjointed from ");
            c1.print();
            Console.WriteLine();

            // whether two circles are disjointed
            c2.print();
            if (c1.disjoint(c2))
                Console.Write(" is disjointed from ");
            else
                Console.Write(" is not disjointed from ");
            c1.print();
            Console.WriteLine();

            // whether one circle contains another
            c1.print();
            if (c4.contained(c1))
                Console.Write(" is contained within ");
            else
                Console.Write(" is not contained within ");
            c4.print();
            Console.WriteLine();

            // whether one circle contains another
            c4.print();
            if (c5.contained(c4))
                Console.Write(" is contained within ");
            else
                Console.Write(" is not contained within ");
            c5.print();
            Console.WriteLine();
        }
    }
}