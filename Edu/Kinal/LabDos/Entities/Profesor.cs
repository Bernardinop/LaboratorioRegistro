using LaboratorioRegistro.Edu.Kinal.LabDos.Interfaces;

namespace LaboratorioRegistro.Edu.Kinal.LabDos.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string CUI { get; set; }
        public string Cargo { get; set; }
        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando Asistencia de {this.Apellidos} {this.Nombres}");
        }
        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.UUID} {this.Apellidos} {this.Nombres} {this.Cargo}");
        }
        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha elminado la asignatura {this.Apellidos} {this.Nombres}");
            return true;
        }
        public Profesor()
        {
        }
        public Profesor(string uuid, string apellidos, string nombres, string email, string CUI, string Cargo)
        : base(uuid, apellidos, nombres, email)
        {
            this.CUI = CUI;
            this.Cargo = Cargo;
        }
    }
}