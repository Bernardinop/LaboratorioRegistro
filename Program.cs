using LaboratorioRegistro.Edu.Kinal.LabDos.Entities;
using LaboratorioRegistro.Edu.Kinal.LabDos.Interfaces;
public class program
{
    private static List<Persona> ListaGeneral = new List<Persona>();
    public static void Main(string[] args)
    {
        Alumno JuanPerez = new Alumno("798", "Ortiz Castro", "Roberto Carlos", "rcarlos@kalum.edu.gt", "2022-001", 30);
        Profesor EdwinTumax = new Profesor("154", "Monzon Perez", "Jose Luis", "jluis@kalum.edu.gt", "249842620101", "Instructor de informática");

        OperarRegistro(JuanPerez);
        OperarRegistro(EdwinTumax);

        RegistrarAsistencia(JuanPerez);
        RegistrarAsistencia(EdwinTumax);

        VerMisDatos(JuanPerez);
        VerMisDatos(EdwinTumax);

        QuitarAsignatura(JuanPerez, "Matematica");
        QuitarAsignatura(EdwinTumax, "Informática");

    }

    public static void VerMisDatos(Persona elemento)
    {
        if (elemento is Alumno)
        {
            Alumno auxiliar = (Alumno)elemento;
            auxiliar.ListarMisDatos(auxiliar.Carne);
        }
        else if (elemento is Profesor)
        {
            Profesor auxiliar = (Profesor)elemento;
            auxiliar.ListarMisDatos(auxiliar.CUI);
        }
    }

    public static void RegistrarAsistencia(Persona elemento)
    {
        foreach (Persona registro in ListaGeneral)
        {
            if (registro.UUID == elemento.UUID)
            {
                elemento.TomarAsistencia();
            }
        }
    }

    public static void QuitarAsignatura(Persona elemento, string asignatura)
    {
        ((IOperaciones)elemento).EliminarAsignatura(asignatura);
    }

    public static void OperarRegistro(Persona elemento)
    {
        ListaGeneral.Add(elemento);
    }


}
