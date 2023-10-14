using ConsoleApp1.Miapp1;

Cuadrado c;
c = new Cuadrado();
Console.WriteLine(" Ingresa el valor del lado1");
double lado1 = double.Parse(Console.ReadLine());
Console.WriteLine(" ingresa el valor del lado2");
double lado2 = double.Parse(Console.ReadLine());
c = new Cuadrado(lado1, lado2);
Console.WriteLine(" El perimetro es " +c.perimetro());
