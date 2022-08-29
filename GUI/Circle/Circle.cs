using System;

namespace Scratchpaper
{
    class Circle : Point
    {
        private double radius;
        public Circle(double xV, double yV, double r)
        {
            this.x = xV;
            this.y = yV;
            this.radius = r;
        }
        public void setRadius(double r)
        {
            radius = r > 0 ? radius : 0;
        }
        public bool onCircle(Point p)
        {
            Point myCenter = new Point();
            myCenter.setPoint(x, y);

            return myCenter.dist(p) == radius;
        }
        public bool inCircle(Point p)
        {
            Point myCenter = new Point();
            myCenter.setPoint(x, y);

            return myCenter.dist(p) < radius;
        }
        public bool outCircle(Point p)
        {
            Point myCenter = new Point();
            myCenter.setPoint(x, y);

            return myCenter.dist(p) > radius;
        }
        public bool intersect(Circle c)
        {
            Point p = new Point(), myCenter = new Point();
            p.setPoint(c.x, c.y);
            myCenter.setPoint(x, y);

            return myCenter.dist(p) < radius + c.radius;
        }
        public bool tangentOut(Circle c)
        {
            Point p = new Point(), myCenter = new Point();
            p.setPoint(c.x, c.y);
            myCenter.setPoint(x, y);

            return myCenter.dist(p) == radius + c.radius;
        }
        public bool tangentIn(Circle c)
        {
            Point p = new Point(), myCenter = new Point();
            p.setPoint(c.x, c.y);
            myCenter.setPoint(x, y);

            return myCenter.dist(p) == radius - c.radius;
        }
        public bool disjoint(Circle c)
        {
            Point p = new Point(), myCenter = new Point();
            p.setPoint(c.x, c.y);
            myCenter.setPoint(x, y);

            return myCenter.dist(p) > radius + c.radius;
        }
        public bool contained(Circle c)
        {
            Point p = new Point(), myCenter = new Point();
            p.setPoint(c.x, c.y);
            myCenter.setPoint(x, y);

            return myCenter.dist(p) < radius - c.radius;
        }
        public void print()
        {
            Console.Write("Circle: ({0}, {1}, {2})", x, y, radius);
        }
    }
}