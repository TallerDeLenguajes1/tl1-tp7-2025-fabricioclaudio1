using System.ComponentModel;
using EspacioEmpleado;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Empleado[] empleado = new Empleado[3];

        empleado[0] = new Empleado("fabri", "claudio", new DateTime(1995, 8, 6), 'C', new DateTime(2020, 2, 1), 650000, Empleado.Cargos.Especialista);

        Console.WriteLine("Monto Total de Salario");
        double salario = empleado[0].Salario();
        Console.WriteLine($"{salario}");

        Console.WriteLine("Otros Datos");
        Console.WriteLine($"{empleado[0].Antiguedad()}");
        Console.WriteLine($"{empleado[0].Edad()}");
        Console.WriteLine($"{empleado[0].AniosParaJubilarse(65)}");

        Console.WriteLine("Datos del empleado mas Proximo a Jubilarse con datos del 2a y salario");


        //fin main 1407500
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


    /* Para escribir los datos de un Empleado por teclado
    Console.WriteLine($"Datos del empleado {i}");
    empleado[i] = new Empleado();

    Console.WriteLine($"Nombre: ");
    empleado[i].Nombre = Console.ReadLine();
    Console.WriteLine($"Apellido");
    empleado[i].Apellido = Console.ReadLine();

    Console.WriteLine($"FechaDeNacimiento: ");
    Console.WriteLine($"Dias (1 al 31): ");
    empleado[i].FechaDeNacimiento.AddDays(NumeroDoublePorTeclado());
    Console.WriteLine($"Mes (1 al 12): ");
    empleado[i].FechaDeNacimiento.AddMonths(NumeroEnteroPorTeclado());
    Console.WriteLine($"Anios: ");
    empleado[i].FechaDeNacimiento.AddYears(NumeroEnteroPorTeclado());

    Console.WriteLine($"EstadoCivil (C: Casado, S: Soltero)");
    resultado = char.TryParse(Console.ReadLine(), out estadoCivil);
    while (!(resultado && (estadoCivil == 'C' || estadoCivil == 'S')))
    {
        Console.WriteLine($"Caracter incorrecto, por favor corregir (C: Casado, S: Soltero)");
        resultado = char.TryParse(Console.ReadLine(), out estadoCivil);
    }
    empleado[i].EstadoCivil = estadoCivil;

    Console.WriteLine($"FechaDeIngresoEnLaEmpresa");
    Console.WriteLine($"Dias (1 al 31): ");
    empleado[i].FechaDeIngresoEnLaEmpresa.AddDays(NumeroDoublePorTeclado());
    Console.WriteLine($"Mes (1 al 12): ");
    empleado[i].FechaDeIngresoEnLaEmpresa.AddMonths(NumeroEnteroPorTeclado());
    Console.WriteLine($"Anios: ");
    empleado[i].FechaDeIngresoEnLaEmpresa.AddYears(NumeroEnteroPorTeclado());

    Console.WriteLine($"SueldoBasico");
    empleado[i].SueldoBasico = NumeroDoublePorTeclado();

    Console.WriteLine($"Cargo (0 : Auxiliar, 1: Administrativo, 2: Ingeniero, 3: Especialista, 4: Investigador)");
    */


    //fin program
}