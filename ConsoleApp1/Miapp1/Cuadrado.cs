namespace ConsoleApp1.Miapp1
{

    public class Cuadrado
    {
        private double lado1;
        private double lado2;

        public Cuadrado()
        {
        }

        public Cuadrado(double lado)
        {
            lado1 = lado;
            lado2 = lado;

        }
        public Cuadrado(double _lado1, double _lado2)
        {
            lado1 = _lado1;
            lado2 = _lado2;
        }
        public double perimetro()
        {
            return (lado1 + lado2) * 2;
        }
    }


}
