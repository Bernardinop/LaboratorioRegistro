using LaboratorioRegistro.Edu.Kinal.LabDos.Interfaces;

namespace LaboratorioRegistro.Edu.Kinal.LabDos.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public override void TomarAsistencia()
        {
            throw new NotImplementedException();
        }

        public void ListarMisDatos(string identificador)
        {
            throw new NotImplementedException();
        }

        public bool EliminarAsignatura(string asignatura)
        {
            throw new NotImplementedException();
        }

        public Alumno()
        {
        }

        public Alumno(string carne, int numeroCreditos)
        {
        }
    }
}