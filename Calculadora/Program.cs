using System.Collections;
using EspacioCalculadora;
public class Program
{
    private static void Main(string[] args)
    {
        Calculadora casio = new Calculadora();
        int select = 1;

        while (select != 0)
        {
            Console.WriteLine($@"
            === MENÚ CALCULADORA ===
            1. Sumar.
            2. Restar.
            3. Multiplicar.
            4. Dividir.
            5. Limpiar.

            0. Salir

            Resultado {casio.Resultado}
            ========================
            ");
            select = NumeroEnteroPorTeclado();

            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("Escribe el numero para Sumar: ");
                        casio.Sumar(NumeroDoublePorTeclado());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Escribe el numero para Restar: ");
                        casio.Restar(NumeroDoublePorTeclado());
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Escribe el numero para Multiplicar: ");
                        casio.Multiplicar(NumeroDoublePorTeclado());
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Escribe el numero para Dividir: ");
                        casio.Dividir(NumeroDoublePorTeclado());
                        break;
                    }
                case 5:
                    {
                        casio.Limpiar();
                        Console.WriteLine("Calculadora limpia.");
                        break;
                    }

            }

        }


        //fin main
    }

    public static double NumeroDoublePorTeclado()
    {
        double numero;

        while (true)
        {
            string? numeroString = Console.ReadLine();
            bool resultado = double.TryParse(numeroString, out numero);
            if (resultado)
            {
                return numero;
            }
            else
            {

                Console.WriteLine("Lo que ingreso no es un numero, vuelve a intentarlo.");
            }
        }
    }

    public static int NumeroEnteroPorTeclado()
    {
        int numero;

        while (true)
        {
            string? numeroString = Console.ReadLine();
            bool resultado = int.TryParse(numeroString, out numero);
            if (resultado)
            {
                return numero;
            }
            else
            {

                Console.WriteLine("Lo que ingreso no es un numero, vuelve a intentarlo.");
            }
        }
    }
    

}