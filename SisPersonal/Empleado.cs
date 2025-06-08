namespace EspacioEmpleado
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadoCivil;
        private DateTime fechaDeIngresoEnLaEmpresa;
        private double sueldoBasico;
        private Cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public DateTime Fechadenacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
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

        
    }
    
}