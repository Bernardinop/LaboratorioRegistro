using LaboratorioRegistro.Edu.Kinal.LabDos.Interfaces;

namespace LaboratorioRegistro.Edu.Kinal.LabDos.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string CUI { get; set; }
        public string Cargo { get; set; }

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

        public Profesor()
        {
        }
        public Profesor(string CUI, string Cargo)
        {
        }
    }
}