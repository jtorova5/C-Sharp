
void Main()
{
    Console.Clear();
    Console.WriteLine("Bienvenido al CRUD de estudiantes!");
    Console.WriteLine();
    Console.WriteLine("1. Mostrar estudiantes");
    Console.WriteLine("2. Agregar estudiante");
    Console.WriteLine("3. Actualizar estudiante");
    Console.WriteLine("4. Eliminar estudiante");
    Console.WriteLine("5. Salir");
    Console.Write("Ingrese una opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            MostrarEstudiantes();
            break;
        case 2:
            AgregarEstudiante();
            break;
        case 3:
            ActualizarEstudiante();
            break;
        case 4:
            EliminarEstudiante();
            break;
        case 5:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción incorrecta. Intente nuevamente.");
            break;
    }

}