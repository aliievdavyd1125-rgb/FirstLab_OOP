using System;

namespace CircleLabratory1
{
    internal class TDisk
    {
        protected double radius;
        protected double x, y;

        public TDisk()
        {
            radius = 15;
            x = 10;
            y = 15;
        }

        public TDisk(double radius, double x, double y)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public TDisk(TDisk other)
        {
            this.radius = other.radius;
            this.x = other.x;
            this.y = other.y;
        }

        public virtual bool Contains(double pointX, double pointY)
        {
            double deltaX = pointX - x;
            double deltaY = pointY - y;

            return (deltaX * deltaX + deltaY * deltaY) <= (radius * radius);
        }

        public virtual void Input()
        {
            Console.Write("Введіть радіус: ");
            radius = double.Parse(Console.ReadLine());

            Console.Write("Введіть X центра: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Введіть Y центра: ");
            y = double.Parse(Console.ReadLine());
        }

        public (double x, double y, double radius) Output()
        {
            return (x, y, radius);
        }

        public virtual double Count_S()
        {
            const double pi = Math.PI;
            return pi * (radius * radius);
        }

        public override string ToString()
        {
            return $"Координати кола (x:{x}, y:{y}), радіус:{radius}";
        }

        public static TDisk operator *(TDisk disk, double c)
        {
            return new TDisk(disk.radius * c, disk.x, disk.y);
        }

        public static TDisk operator *(double c, TDisk disk)
        {
            return new TDisk(disk.radius * c, disk.x, disk.y);
        }
    }

    class TBall : TDisk
    {
        protected double z;

        public TBall() : base()
        {
            z = 10;
        }

        public TBall(double radius, double x, double y, double z)
            : base(radius, x, y)
        {
            this.z = z;
        }

        public TBall(TBall other) : base(other)
        {
            this.z = other.z;
        }

        public bool Contains(double pointX, double pointY, double pointZ)
        {
            double deltaX = pointX - x;
            double deltaY = pointY - y;
            double deltaZ = pointZ - z;

            double distanceSquared = deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ;

            return distanceSquared <= (radius * radius);
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Введіть Z центра: ");
            z = double.Parse(Console.ReadLine());
        }

        public (double x, double y, double z, double radius) Output()
        {
            return (x, y, z, radius);
        }

        public override double Count_S()
        {
            const double pi = Math.PI;
            return 4 * pi * (radius * radius);
        }

        public double Count_V()
        {
            const double pi = Math.PI;
            return (4.0 / 3.0) * pi * Math.Pow(radius, 3);
        }

        public override string ToString()
        {
            return $"Координати кулі (x:{x}, y:{y}, z:{z}), радіус:{radius}";
        }

        public static TBall operator *(TBall ball, double c)
        {
            return new TBall(ball.radius * c, ball.x, ball.y, ball.z);
        }

        public static TBall operator *(double c, TBall ball)
        {
            return new TBall(ball.radius * c, ball.x, ball.y, ball.z);
        }
    }
}
