double radius;
static double AreaOfCircle(double r)
{
    double AreaOfCircle = (Math.PI * (r * r));
    return AreaOfCircle;
}
Console.WriteLine("What is the radius of your circle?");
radius = Double.Parse(Console.ReadLine());
Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");