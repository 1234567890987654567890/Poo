//Console.WriteLine("Ingrese el valor del monsto");
//double prestamo = double.Parse(Console.ReadLine());

//double tasa = 0.05;
//int años = 5;

//double interesAnual = prestamo * tasa;
//double interesTrimestre = interesAnual / 4;
//double interesMensual =  interesAnual / 12;
//double totalIntereses = interesAnual * años;
//double totalPagar = prestamo + totalIntereses;

//Console.WriteLine("Interes pagado en un año: $" + interesAnual);
//Console.WriteLine("Interes pagado en el tercer trimestre: $" + interesTrimestre);
//Console.WriteLine("Interes pagado en el primer mes: $" + interesMensual);
//Console.WriteLine("Total a pagar: $" + totalPagar);




//----------------Ejercicio 2------------

//Console.Write("Ingrese el salario del empleado: ");
//double salario = double.Parse(Console.ReadLine());

//Console.Write("Ingrese el valor del ahorro mensual programado: ");
//double ahorro = double.Parse(Console.ReadLine());

//double salud = salario * 0.125;
//double pension = salario * 0.16;
//double totalDeducciones = salud + pension + ahorro;
//double totalRecibir = salario - totalDeducciones;

//Console.WriteLine("\n--- Colilla de Pago ---");
//Console.WriteLine("Salario: $" + salario);
//Console.WriteLine("Ahorro mensual: $" + ahorro);
//Console.WriteLine("Deducción por salud (12.5%): $" + salud);
//Console.WriteLine("Deducción por pensión (16%): $" + pension);
//Console.WriteLine("Total a recibir: $" + totalRecibir);



//------------Ejercicio 3--------------

//class Persona
//{
//    public string Nombre;
//    public int Edad;
//    public string Genero;
//    public string Telefono;

//    public Persona(string nombre, int edad, string genero, string telefono)
//    {
//        Nombre = nombre;
//        Edad = edad;
//        Genero = genero;
//        Telefono = telefono;
//    }

//    public void ImprimirDetalles()
//    {
//        Console.WriteLine("\n--- Detalles de la Persona ---");
//        Console.WriteLine("Nombre: " + Nombre);
//        Console.WriteLine("Edad: " + Edad);
//        Console.WriteLine("Género: " + Genero);
//        Console.WriteLine("Teléfono: " + Telefono);
//    }

//    public void CalcularEdadEnDias()
//    {
//        int edadDias = Edad * 365;
//        Console.WriteLine("La edad en días es aproximadamente: " + edadDias + " días.");
//    }
//}

//class Programa
//{
//    static void Main()
//    {
//        Console.WriteLine("PROGRAMA AGENDA");
//        Console.Write("Ingrese el nombre: ");
//        string nombre = Console.ReadLine();

//        Console.Write("Ingrese la edad: ");
//        int edad = int.Parse(Console.ReadLine());

//        Console.Write("Ingrese el género (F o M): ");
//        string genero = Console.ReadLine();

//        Console.Write("Ingrese el número de teléfono: ");
//        string telefono = Console.ReadLine();

//        Persona persona = new Persona(nombre, edad, genero, telefono);

//        Console.WriteLine("\n¿Qué desea hacer?");
//        Console.WriteLine("1. Imprimir detalles");
//        Console.WriteLine("2. Calcular edad en días");
//        Console.Write("Seleccione una opción (1 o 2): ");
//        int opcion = int.Parse(Console.ReadLine());

//        if (opcion == 1)
//        {
//            persona.ImprimirDetalles();
//        }
//        else if (opcion == 2)
//        {
//            persona.CalcularEdadEnDias();
//        }
//        else
//        {
//            Console.WriteLine("Opción no válida.");
//        }
//    }
//}


//--------------Ejercicio 4-----------
//class Libro
//{
//    public string Titulo;
//    public string Autor;
//    public string Editorial;
//    public int AnioPublicacion;

//    public Libro(string titulo, string autor, string editorial, int anio)
//    {
//        Titulo = titulo;
//        Autor = autor;
//        Editorial = editorial;
//        AnioPublicacion = anio;
//    }

//    public void MostrarInfo()
//    {
//        Console.WriteLine("Título: " + Titulo);
//        Console.WriteLine("Autor: " + Autor);
//        Console.WriteLine("Editorial: " + Editorial);
//        Console.WriteLine("Año de publicación: " + AnioPublicacion);
//        Console.WriteLine("--------------------------");
//    }
//}

//class Biblioteca
//{
//    public List<Libro> libros = new List<Libro>();

//    public void AgregarLibro(Libro libro)
//    {
//        libros.Add(libro);
//    }

//    public void ListarLibros()
//    {
//        if (libros.Count == 0)
//        {
//            Console.WriteLine("No hay libros registrados.");
//        }
//        else
//        {
//            Console.WriteLine("\n--- Lista de Libros ---");
//            foreach (Libro libro in libros)
//            {
//                libro.MostrarInfo();
//            }
//        }
//    }

//    public void BuscarLibro(string nombre)
//    {
//        bool encontrado = false;
//        foreach (Libro libro in libros)
//        {
//            if (libro.Titulo.ToLower() == nombre.ToLower())
//            {
//                Console.WriteLine("\nLibro encontrado:");
//                libro.MostrarInfo();
//                encontrado = true;
//                break;
//            }
//        }

//        if (!encontrado)
//        {
//            Console.WriteLine("No se encontró un libro con ese título.");
//        }
//    }
//}

//class Programa
//{
//    static void Main()
//    {
//        Biblioteca biblioteca = new Biblioteca();
//        int opcion = 0;

//        while (opcion != 4)
//        {
//            Console.WriteLine("\n--- ADMINISTRACIÓN DE BIBLIOTECA ---");
//            Console.WriteLine("1. Agregar libro");
//            Console.WriteLine("2. Listar libros");
//            Console.WriteLine("3. Buscar libro");
//            Console.WriteLine("4. Salir");
//            Console.Write("Seleccione una opción: ");
//            opcion = int.Parse(Console.ReadLine());

//            if (opcion == 1)
//            {
//                Console.Write("Ingrese el título del libro: ");
//                string titulo = Console.ReadLine();
//                Console.Write("Ingrese el autor: ");
//                string autor = Console.ReadLine();
//                Console.Write("Ingrese la editorial: ");
//                string editorial = Console.ReadLine();
//                Console.Write("Ingrese el año de publicación: ");
//                int anio = int.Parse(Console.ReadLine());

//                Libro nuevo = new Libro(titulo, autor, editorial, anio);
//                biblioteca.AgregarLibro(nuevo);
//                Console.WriteLine("Libro agregado correctamente.");
//            }
//            else if (opcion == 2)
//            {
//                biblioteca.ListarLibros();
//            }
//            else if (opcion == 3)
//            {
//                Console.Write("Ingrese el título del libro a buscar: ");
//                string nombre = Console.ReadLine();
//                biblioteca.BuscarLibro(nombre);
//            }
//            else if (opcion == 4)
//            {
//                Console.WriteLine("Saliendo del programa...");
//            }
//            else
//            {
//                Console.WriteLine("Opción no válida.");
//            }
//        }
//    }
//}


//---------------Ejercicio 5--------------