using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape (string name)
        {
            Name = name;
        }

        public abstract void Draw (Graphics g, Rectangle r);
    }

    public class Circle : Shape
    {
        public Circle() : base("Circle") { }

        public override void Draw(Graphics g, Rectangle r)
        {
            g.FillEllipse(Brushes.Blue, r);
        }
    }

    public class Square : Shape
    {
        public Square() : base("Square") { }

        public override void Draw(Graphics g, Rectangle r)
        {
            int size = Math.Min(r.Width, r.Height);
            int x = r.Left + (r.Width - size) / 2;
            int y = r.Top + (r.Height - size) / 2;

            g.FillRectangle(Brushes.Red, x, y, size, size);
        }
    }

    public class Triangle : Shape
    {
        public Triangle() : base("Triangle") { }

        public override void Draw(Graphics g, Rectangle r)
        {
            Point[] points =
            {
                new Point(r.Left + r.Width / 2, r.Top),
                new Point(r.Left, r.Bottom),
                new Point(r.Right, r.Bottom)
            };

            g.FillPolygon(Brushes.Green, points);
        }
    }

    public class Pentagon : Shape
    {
        public Pentagon() : base("Pentagon") { }

        public override void Draw(Graphics g, Rectangle r)
        {
            Point[] points =
       {
            new Point(r.Left + r.Width / 2, r.Top),
            new Point(r.Right, r.Top + r.Height / 3),
            new Point(r.Right - r.Width / 4, r.Bottom),
            new Point(  r   .Left + r.Width / 4, r.Bottom),
            new Point(r.Left, r.Top + r.Height / 3)
        };
            g.FillPolygon(Brushes.Purple, points);
        }
    }

    public class Hexagon : Shape
    {
        public Hexagon() : base("Hexagon") { }

        public override void Draw(Graphics g, Rectangle r)
        {
            int width = r.Width;
            int height = r.Height;
            Point[] points =
            {
            new Point(r.Left + width / 4, r.Top),
            new Point(r.Right - width / 4, r.Top),
            new Point(r.Right, r.Top + height / 2),
            new Point(r.Right - width / 4, r.Bottom),
            new Point(r.Left + width / 4, r.Bottom),
            new Point(r.Left, r.Top + height / 2)
        };
            g.FillPolygon(Brushes.Orange, points);
        }
    }

    public class Rhombus : Shape
    {
        public Rhombus() : base("Rhombus") { }

        public override void Draw(Graphics g, Rectangle r)
        {
            int width = r.Width;
            int height = r.Height;
            Point[] points =
            {
            new Point(r.Left + width / 2, r.Top),
            new Point(r.Right, r.Top + height / 2),
            new Point(r.Left + width / 2, r.Bottom),
            new Point(r.Left, r.Top + height / 2)
        };
            g.FillPolygon(Brushes.Pink, points);
        }
    }


}
