namespace Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            // Instancing of new objects from the class Geometry
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            Circle circle = new Circle();
            Parallelogram parallelogram = new Parallelogram();  
            Ellipse ellips = new Ellipse();

            // An array holding the newly created objects
            Geometry [] figures = { rectangle, square, circle, parallelogram, ellips};

            // A foreach loop to display the objects
            foreach(Geometry figure in figures )
            {
                figure.Area(); // Invoking the method Area to calculate the areas of the objects
            }
        }
    }
    internal class Geometry // A new parent class 
    {
        public virtual void Area() // Method that can be overridden by the inheriting child classes
        {
        }
    }
    internal class Rectangle : Geometry // Child class from parent class Geometry
    {
        // Fields
        public double _sideLength { get; set; }
        public double _sideWidth { get; set; }
        public Rectangle(double sideLength = 5, double sideWidth = 6) // Constructor with parameters
        {
            _sideLength = sideLength;
            _sideWidth = sideWidth;
        }
        public override void Area() // Method that calculates area and returns result when invoked 
        {
            double areaRectangle = _sideLength * _sideWidth; // Formula for calculating area of rectangle 
            Console.WriteLine($"Area of rectangle is: {areaRectangle}"); // Displays the area 
        }
    }
    internal class Square : Geometry // Child class from parent class Geometry
    {
        // Fields
        public double _sideSquare { get; set; }
        public Square(double sideSquare = 5.5) // Constructor with parameters
        {
            _sideSquare = sideSquare;
        }
        public override void Area()
        {
            double areaSquare = Math.Pow(_sideSquare, 2); // Formula for calculating area of square using the Math method raised to the power of 2
            Console.WriteLine($"Area of square is: {areaSquare}");
        }
    }
    internal class Circle : Geometry // Child class from parent class Geometry
    {
        public double _radius { get; set; }
        double _pi = Math.PI; // Declaring a field and assigning it with the value of Pi by using the Math method 
        public Circle(double radius = 5.5)
        {
            _radius = radius;            
        }
        public override void Area()
        {
            double areaCircle = _pi *_radius * _radius;            
            string abbreviatedResult = areaCircle.ToString("F3");// Displays the result with 3 decimal places
            Console.WriteLine($"Area of circle is: {abbreviatedResult}");
        }
    }
    internal class Parallelogram : Geometry //Child class from parent class Geometry
    {
        public double _height { get; set; }
        public double _basis { get; set; }
        public Parallelogram(double height = 5, double basis = 6)
        {
            _height = height;
            _basis = basis;
        }
        public override void Area()
        {
            double areaParallelogram = _basis * _height; // Formula for calculating area of parallelogram
            Console.WriteLine($"Area of parallelogram is: {areaParallelogram}");
        }
    }
    internal class Ellipse : Geometry // Child class from parent class Geometry
    {
        public double _axisLong { get; set; }
        public double _axisShort { get; set; }
        double _pi = Math.PI;
        public Ellipse(double axisLong = 6, double axisShort = 4)
        {
            _axisLong = axisLong;
            _axisShort = axisShort;
        }
        public override void Area()
        {
            double areaEllipse = _pi * _axisLong * _axisShort; // Formula for calculating area of ellipse
            string abbreviatedResult = areaEllipse.ToString("F3");// Displays the result with 3 decimal places
            Console.WriteLine($"Area of ellipse is: {abbreviatedResult}");
        }
    }
}
