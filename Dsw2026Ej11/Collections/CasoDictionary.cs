namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Domain.Alumno> _alumnos = new Dictionary<int, Domain.Alumno>();
 
    public void AgregarAlumno(Domain.Alumno alumno)
    {
        _alumnos[alumno.Id] = alumno;
    }
 
    public Domain.Alumno? BuscarPorClave(int legajo)
    {
        return _alumnos.TryGetValue(legajo, out var alumno) ? alumno : null;
    }
 
    public Dictionary<int, Domain.Alumno> GetAlumnos()
    {
        return _alumnos;
    }
 
    public void EliminarAlumno(int legajo)
    {
        _alumnos.Remove(legajo);
    }


}
