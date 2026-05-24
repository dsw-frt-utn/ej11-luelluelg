namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var casoList = new CasoList();
 
        // Agregar 3 alumnos a la lista
        var a1 = new Alumno(1, "Ana Garcia", 8.5);
        var a2 = new Alumno(2, "Carlos López", 7.0);
        var a3 = new Alumno(3, "Maria Fernandez", 9.2);
 
        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);
 
        
        Console.WriteLine("=== Lista de alumnos ===");
        foreach (var alumno in casoList.GetAlumnos())
            Console.WriteLine(alumno);
 
        // buscar por nombre
        Console.WriteLine("\n=== Buscar 'Carlos López' ===");
        var encontrado = casoList.BuscarPorNombre("Carlos López");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");
 
        //  alumno que no exista
        Console.WriteLine("\n=== Buscar 'Pedro Ramírez' ===");
        var noEncontrado = casoList.BuscarPorNombre("Pedro Ramírez");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");
 
        
        Console.WriteLine("\n=== Eliminar Ana García ===");
        casoList.EliminarAlumno(a1);
        foreach (var alumno in casoList.GetAlumnos())
            Console.WriteLine(alumno);
 
        
        Console.WriteLine("\n=== Eliminar primer elemento ===");
        casoList.EliminarEnPosicion(0);
        foreach (var alumno in casoList.GetAlumnos())
            Console.WriteLine(alumno);

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var casoDictionary = new CasoDictionary();
 
        // Agregar 3 alumnos al diccionario
        var a1 = new Alumno(101, "Laura Martínez", 8.0);
        var a2 = new Alumno(102, "Diego Sánchez", 6.5);
        var a3 = new Alumno(103, "Sofía Torres", 9.5);
 
        casoDictionary.AgregarAlumno(a1);
        casoDictionary.AgregarAlumno(a2);
        casoDictionary.AgregarAlumno(a3);
 
        
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in casoDictionary.GetAlumnos())
            Console.WriteLine($"Clave: {par.Key} => {par.Value}");
 
        // buscarpor clave que exista
        Console.WriteLine("\n=== Buscar clave 102 ===");
        var encontrado = casoDictionary.BuscarPorClave(102);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");
 
        //  clave que no exista
        Console.WriteLine("\n=== Buscar clave 999 ===");
        var noEncontrado = casoDictionary.BuscarPorClave(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");
 
       
        Console.WriteLine("\n=== Eliminar clave 101 ===");
        casoDictionary.EliminarAlumno(101);
        foreach (var par in casoDictionary.GetAlumnos())
            Console.WriteLine($"Clave: {par.Key} => {par.Value}");

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
                var casoLinq = new CasoLinq();
 
        Console.WriteLine("=== 1. Primer libro ===");
        Console.WriteLine(casoLinq.GetPrimero().Titulo);
 
        Console.WriteLine("\n=== 2. Ultimo libro ===");
        Console.WriteLine(casoLinq.GetUltimo().Titulo);
 
        Console.WriteLine("\n=== 3. Suma de precios ===");
        Console.WriteLine($"{casoLinq.GetTotalPrecios():C}");
 
        Console.WriteLine("\n=== 4. Promedio de precios ===");
        Console.WriteLine($"{casoLinq.GetPromedioPrecios():F2}");
 
        Console.WriteLine("\n=== 5. Libros con Id > 15 ===");
        foreach (var libro in casoLinq.GetListById())
            Console.WriteLine($"{libro.Id} - {libro.Titulo}");
 
        Console.WriteLine("\n=== 6. Titulos y precios en formato moneda ===");
        foreach (var linea in casoLinq.GetLibros())
            Console.WriteLine(linea);
 
        Console.WriteLine("\n=== 7. Libro con mayor precio ===");
        var mayor = casoLinq.GetMayorPrecio();
        Console.WriteLine($"{mayor.Titulo} - {mayor.Precio:C}");
 
        Console.WriteLine("\n=== 8. Libro con menor precio ===");
        var menor = casoLinq.GetMenorPrecio();
        Console.WriteLine($"{menor.Titulo} - {menor.Precio:C}");
 
        Console.WriteLine("\n=== 9. Libros con precio mayor al promedio ===");
        foreach (var libro in casoLinq.GetMayorPromedio())
            Console.WriteLine($"{libro.Titulo} - {libro.Precio:C}");
 
        Console.WriteLine("\n=== 10. Libros ordenados por titulo descendente ===");
        foreach (var libro in casoLinq.GetOrdenadosPorTituloDesc())
            Console.WriteLine(libro.Titulo);

    }
}
