namespace EjercicioHerencia
{
    public class Operaciones
    {
        public double CalcularAreaCirculo (double radio)
        {
            return Math.PI * Math.Pow (radio, 2);
        }
        public double CalcularLongitudCirculo (double radio)
        {
            return 2 * Math.PI *radio;
        }
        public double CalcularVolumerEsfera(double radio)
        {
            return (4/3) * Math.PI * Math.Pow(radio, 3);
        }
    }
}
