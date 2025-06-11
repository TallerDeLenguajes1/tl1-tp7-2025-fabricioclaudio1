namespace EspacioEmpleado
{
    public class Empleado
    {
        private string? nombre;
        private string? apellido;
        private DateTime fechaDeNacimiento;
        private char estadoCivil;
        private DateTime fechaDeIngresoEnLaEmpresa;
        private double sueldoBasico;
        private Cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento,
        char estadoCivil, DateTime fechaDeIngresoEnLaEmpresa, double sueldoBasico, Cargos cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
            EstadoCivil = estadoCivil;
            FechaDeIngresoEnLaEmpresa = fechaDeIngresoEnLaEmpresa;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;

        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaDeIngresoEnLaEmpresa { get => fechaDeIngresoEnLaEmpresa; set => fechaDeIngresoEnLaEmpresa = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
        public int Antiguedad()
        {
            DateTime hoy = DateTime.Today;
            int antiguedad = hoy.Year - FechaDeIngresoEnLaEmpresa.Year;

            if (FechaDeIngresoEnLaEmpresa.Date > hoy.AddYears(-antiguedad))
            {
                antiguedad--;
            }

            return antiguedad;
        }

        public int Edad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaDeNacimiento.Year;

            if (FechaDeNacimiento > hoy.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public int AniosParaJubilarse(int edadJubilacion)
        {
            DateTime hoy = DateTime.Today;
            DateTime fechaDeJubilacion = fechaDeNacimiento.AddYears(edadJubilacion);
            int aniosParaJubilarse = fechaDeJubilacion.Year - hoy.Year;

            if (hoy > fechaDeJubilacion.AddYears(-aniosParaJubilarse))
            {
                aniosParaJubilarse--;
            }

            return aniosParaJubilarse;
        }

        public double Salario()
        {
            double adicional = 0;

            int antiguedad = Antiguedad();

            if (1 <= antiguedad && antiguedad <= 20)
            {
                adicional += SueldoBasico * 0.15;
            }
            else
            {
                if (Antiguedad()>20)
                {
                    adicional += SueldoBasico * 0.25;
                }
            }

            if (Cargo == Cargos.Ingeniero || this.Cargo == Cargos.Especialista)
            {
                adicional += adicional * 0.5;
            }

            if (EstadoCivil == 'C')
            {
                adicional += 150000;
            }

            return SueldoBasico + adicional;
        }


        
    }
    
}