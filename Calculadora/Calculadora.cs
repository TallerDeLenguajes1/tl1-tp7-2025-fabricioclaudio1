namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public double Resultado
        {
            get => dato;
        }

        public Calculadora()
        {
            dato = 0;
        }

        public void Sumar(double termino)
        {
            dato = dato + termino;

        }
        public void Restar(double termino)
        {
            dato = dato - termino;
        }
        public void Multiplicar(double termino)
        {
            dato = dato * termino;
        }
        public void Dividir(double termino)
        {

            if (termino == 0)
            {
                Console.WriteLine("No se puede dividir en 0.");
            }
            else
            {
                dato = dato / termino;
            }
        }
        public void Limpiar()
        {
            dato = 0;
        }
        
    }

}