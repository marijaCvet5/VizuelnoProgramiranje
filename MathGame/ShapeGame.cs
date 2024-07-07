using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class ShapeGame
    {
        private Random random = new Random();
        public int Tries { get; set; } = 3;
        public Shape CurrentShape { get; set; }

        private List<Shape> shapes = new List<Shape>
        {
            new Circle(),
            new Square(),
            new Triangle(),
            new Pentagon(),
            new Hexagon(),
            new Rhombus()
        };

        public void GenerateRandomShape()
        {
            CurrentShape = shapes[random.Next(shapes.Count)];
        }

        public bool CheckAnswer(string answer)
        {
            if (string.Equals(answer, CurrentShape.Name, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                Tries--;
                return false;
            }
        }
    }
}
