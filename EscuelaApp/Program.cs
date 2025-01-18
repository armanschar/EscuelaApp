namespace EscuelaApp
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    public class Estudiante : Persona
    {
        public int NumeroUnico { get; set; }

        public Estudiante(string nombre, int numeroUnico) : base(nombre)
        {
            NumeroUnico = numeroUnico;
        }
    }

    public class Profesor : Persona
    {
        public List<Curso> Cursos { get; set; }

        public Profesor(string nombre) : base(nombre)
        {
            Cursos = new List<Curso>();
        }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }
    }

    public class Curso
    {
        public string Nombre { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }

        public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
        {
            Nombre = nombre;
            RecuentoClases = recuentoClases;
            RecuentoEjercicios = recuentoEjercicios;
        }
    }

    public class Clase
    {
        public string Identificador { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public List<Profesor> Profesores { get; set; }

        public Clase(string identificador)
        {
            Identificador = identificador;
            Estudiantes = new List<Estudiante>();
            Profesores = new List<Profesor>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
    }

    public class Escuela
    {
        public string Nombre { get; set; }
        public List<Clase> Clases { get; set; }

        public Escuela(string nombre)
        {
            Nombre = nombre;
            Clases = new List<Clase>();
        }

        public void AgregarClase(Clase clase)
        {
            Clases.Add(clase);
        }
    }
}