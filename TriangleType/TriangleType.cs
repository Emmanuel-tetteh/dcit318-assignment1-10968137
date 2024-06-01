// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Enter length of the triangle base");
int x = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Enter length of the triangle 1st Leg");
int y = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Enter length of the triangle 2nd Leg");
int z = Convert.ToInt32(System.Console.ReadLine());

if (z == y && z == x)
{
    System.Console.WriteLine("This is an Equilateral Triangle");
}

else if (z == y && z != x && x != y)
{
    System.Console.WriteLine("This is an Isoceles Triangle");
}
else if (x == y && z != x && z != y)
{
    System.Console.WriteLine("This is an Isoceles Triangle");
}
else if (z == x && y != x && z != y)

{
    System.Console.WriteLine("This is an Isoceles Triangle");
}
else if (z != y && z != x && y != x)
{
    System.Console.WriteLine("This is an Scalene Triangle");
}