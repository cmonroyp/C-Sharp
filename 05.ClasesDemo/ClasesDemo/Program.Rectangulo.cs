namespace ClasesDemo
{
    partial class Program
    {
        class Rectangulo
        {
            double baseRectangulo, alturaRectangulo;
            string color;

          public  Rectangulo(){

                baseRectangulo = 0;
                alturaRectangulo = 0;
                color = "Negro";
            }

            public Rectangulo(double baseRectanguloInicial,double alturaRectanguloInicial)
            {
                baseRectangulo = baseRectanguloInicial;
                alturaRectangulo = alturaRectanguloInicial;
            }

            //ejemplo metodo estatico
            public static double calculaPerimetroRectangulo(int baserect, int altrect)
            {
                return (2 * baserect) + (2 * altrect);
            }
           public double CalcularArea()
            {
                return baseRectangulo * alturaRectangulo;
            }

          public  double CalcularPerimetro()
            {
                return (2 * alturaRectangulo) + (2 * baseRectangulo);
            }

            public void Deconstruct(out double baseRect,out double alturaRect)
            {
                baseRect = baseRectangulo;
                alturaRect = alturaRectangulo;
            }
        }
    }
}
