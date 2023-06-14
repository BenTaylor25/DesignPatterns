
namespace Visitor
{
    interface IShapeVisitor
    {
        public void visit(Circle circle);
        public void visit(Rectangle rectangle);
    }

    interface IShape
    {
        public void accept(IShapeVisitor visitor);
    }

    class Circle : IShape
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void accept(IShapeVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    class Rectangle : IShape
    {
        public double width;
        public double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public void accept(IShapeVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    class AreaCalculator : IShapeVisitor
    {
        public void visit(Circle circle)
        {
            double area = Math.PI * circle.radius * circle.radius;
            Console.WriteLine($"Area of circle: {area}");
        }

        public void visit(Rectangle rectangle)
        {
            double area = rectangle.width * rectangle.height;
            Console.WriteLine($"Area of rectangle: {area}");
        }
    }

    class Visitor
    {
        public static void Execute()
        {
            List<IShape> shapes = new List<IShape>{
                new Circle(5),
                new Rectangle(4, 5),
                new Circle(10),
            };

            AreaCalculator areaCalculator = new();
            foreach (var shape in shapes)
            {
                if (shapes.First() != shape)
                {
                    Console.WriteLine();
                }

                shape.accept(areaCalculator);
            }

        }
    }
}