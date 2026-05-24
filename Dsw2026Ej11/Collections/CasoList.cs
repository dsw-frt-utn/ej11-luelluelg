namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
   private List<Domain.Alumno> _alumnos = new List<Domain.Alumno>();
 
    public void AgregarAlumno(Domain.Alumno alumno)
    {
        _alumnos.Add(alumno);
    }
 
    public List<Domain.Alumno> GetAlumnos()
    {
        return _alumnos;
    }
 
    public Domain.Alumno? BuscarPorNombre(string nombre)
    {
        return _alumnos.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }
 
    public void EliminarAlumno(Domain.Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }
 
    public void EliminarEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _alumnos.Count)
            _alumnos.RemoveAt(posicion);
    } 
}
