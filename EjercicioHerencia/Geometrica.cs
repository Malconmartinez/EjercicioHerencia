namespace EjercicioHerencia
{
    public class Geometrica : Operaciones
    {
        private double radio;
        public Geometrica(double radio) 
        {
        this.radio = radio;
        }
      public void Imprimir()
        {
            double area = CalcularAreaCirculo(radio);
            double longitud = CalcularLongitudCirculo(radio);
            double volume = CalcularVolumerEsfera(radio);
            Console.WriteLine($"Area del circulo: {area}");
            Console.WriteLine($"Longitud del circulo: {longitud}");
            Console.WriteLine($"Volumen de la esfera: {volume}");
        }
    }
}
