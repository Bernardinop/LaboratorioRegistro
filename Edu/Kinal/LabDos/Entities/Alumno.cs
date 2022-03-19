using LaboratorioRegistro.Edu.Kinal.LabDos.Interfaces;

namespace LaboratorioRegistro.Edu.Kinal.LabDos.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando asistencia de {this.Apellidos} {this.Nombres}");
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.UUID} {this.Apellidos} {this.Nombres} {this.NumeroCreditos}");
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.Apellidos} {this.Nombres}, perdera la cantidad de créditos {this.NumeroCreditos}");
            return true;
        }

        public Alumno()
        {
        }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
        : base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }
    }
}