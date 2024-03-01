// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Hello, World!");
Console.WriteLine("Original instances of MyPoint class");
List<MyPoint> points = new List<MyPoint> {
    new MyPoint(15,3),
    new MyPoint(12,3)
};


foreach(MyPoint mp in points) {
    Console.WriteLine($"{mp.X},{mp.Y}");
}

Console.WriteLine("Modified instances of MyPoint class");
points.ForEach(p=> p.X -=10);

foreach (MyPoint mp in points) {
    Console.WriteLine($"{mp.X},{mp.Y}");
}

Console.WriteLine("Original values of instances of Point struct");
List<Point> pointsValue= new List<Point> { 
    new Point(15,4), new Point(12,4)
};

foreach(Point p in pointsValue) {
    Console.WriteLine($"{p.X},{p.Y}");
}

Console.WriteLine("Modified values of instances of Point struct");
pointsValue.ForEach(pv=> pv.X-=10);

foreach(Point p in pointsValue) {
    Console.WriteLine($"{p.X},{p.Y}");
}



