// See https://aka.ms/new-console-template for more information
Console.WriteLine("Juego de la Vida - Programacion 1, 2025-02");

string genero = "No Definido";
bool terminoColegio = false;
bool universidad = false;
bool escuelaTecnica = false;
bool graduarse = false;
string carrera = "No Definida";
string resultado = "No has completado tu vida";

// INICIO SE SELECCION DE GENERO
SELECCION_DE_GENERO:
Console.WriteLine("Seleccione su genero: ");
Console.WriteLine("1 - Masculino");
Console.WriteLine("2 - Femenino");

try {
    int respuesta = int.Parse(Console.ReadLine() ?? "0");
    if (respuesta == 1) {
        genero = "Masculino";
    } else if (respuesta == 2) {
        genero = "Femenino";
    } else {
        Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
        goto SELECCION_DE_GENERO;
    }
} catch (Exception e) {
    Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
    goto SELECCION_DE_GENERO;
}
// FIN SE SELECCION DE GENERO


// INICIO SI TERMINA COLEGIO
SELECCION_TERMINO_COLEGIO:
Console.WriteLine("Luego de haber disfrutado de tu niñez, y parte de tu adolesencia te vez terminando tus estudios secundarios? ");
Console.WriteLine("1 - SI");
Console.WriteLine("2 - NO");

try
{
    int respuesta = int.Parse(Console.ReadLine() ?? "0");
    if (respuesta == 1)
    {
        terminoColegio = true;
    }
    else if (respuesta == 2)
    {
        terminoColegio = false;
    }
    else
    {
        Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
        goto SELECCION_TERMINO_COLEGIO;
    }
}
catch (Exception e)
{
    Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
    goto SELECCION_TERMINO_COLEGIO;
}
// FIN SE SELECCION DE TERMINO COLEGIO

// si termino colegio, se pregunta si va a universidad o escuela tecnica
if (terminoColegio == true)
{
// INICIO SI UNIVERSIDAD O ESCUELA TECNICA
SELECCION_UNIVERSIDAD_ESCUELA_TECNICA:
    Console.WriteLine("Luego de haber terminado satisfactoriamente tus estudios primarios y secundarios, piensas seguir con una carrera profesional asistiendo a la universidad, o quieres tomar un curso tecnico que te permita trabajar mas rapido? ");
    Console.WriteLine("1 - Universidad");
    Console.WriteLine("2 - Escuela Tecnica");

    try
    {
        int respuesta = int.Parse(Console.ReadLine() ?? "0");
        if (respuesta == 1)
        {
            universidad = true;
        }
        else if (respuesta == 2)
        {
            escuelaTecnica = true;
        }
        else
        {
            Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
            goto SELECCION_UNIVERSIDAD_ESCUELA_TECNICA;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
        goto SELECCION_UNIVERSIDAD_ESCUELA_TECNICA;
    }
    // FIN SI UNIVERSIDAD O ESCUELA TECNICA
}

// no termino colegio, se le indica que su unica opcion es una escuela tecnica
if (terminoColegio == false)
{
// INICIO ESCUELA TECNICA
SELECCION_ESCUELA_TECNICA:
    Console.WriteLine("No terminaste tus estudios secundarios, por esta razon tus opciones de estudio y superacion son inferiores, quieres optar por lo menos por hacer una carrera tecnica, de esta forma podras tener un trabajo? ");
    Console.WriteLine("1 - SI");
    Console.WriteLine("2 - NO");

    try
    {
        int respuesta = int.Parse(Console.ReadLine() ?? "0");
        if (respuesta == 1)
        {
            escuelaTecnica = true;
        }
        else if (respuesta == 2)
        {
            escuelaTecnica = false;
        }
        else
        {
            Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
            goto SELECCION_ESCUELA_TECNICA;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
        goto SELECCION_ESCUELA_TECNICA;
    }
    // FIN ESCUELA TECNICA

}

//PRIMERA VERIFICACION DE ESTUDIOS Y SALIDA DEL JUEGO
if (escuelaTecnica == false && universidad == false)
{
    resultado = "En el Juego de la Vida, esta elección tiene consecuencias importantes. Al no prepararte académicamente ni adquirir una formación técnica o profesional, cierras las puertas al mundo laboral y a las oportunidades de desarrollo personal. Sin ingresos ni estabilidad, te será imposible formar una familia o alcanzar metas significativas. En este juego, como en la vida real, el esfuerzo y la superación son claves del éxito. Esta decisión te aleja del progreso… y te deja fuera del camino hacia una vida plena.";

    Console.WriteLine("Has decidido no continuar tus estudios, por lo tanto no puedes continuar con el juego.");
    Console.WriteLine(resultado);
    Console.WriteLine("Presiona cualquier tecla para salir...");
    System.Environment.Exit(0);
}
//PRIMERA VERIFICACION DE ESTUDIOS Y SALIDA DEL JUEGO

// Escogio Estudiar en la universidad o escuela tecnica
if (escuelaTecnica == true || universidad == true)
{
// INICIO SELECCION CARRERA
SELECCION_CARRERA:
    if (escuelaTecnica == true)
    {
        Console.WriteLine("Haz tomado la desicion de estudiar en una escuela tecnica, que carrera tecnica te interesa? ");
        if(genero == "Masculino")
        {
            Console.WriteLine("1 - Programacion de Software");
            Console.WriteLine("2 - Mecanica Automotriz");
            Console.WriteLine("3 - Electricidad Industrial");
            Console.WriteLine("4 - Carpinteria");
        }
        else if (genero == "Femenino")
        {
            Console.WriteLine("1 - Cosmetologia");
            Console.WriteLine("2 - Cocina Profesional");
            Console.WriteLine("3 - Asistente Administrativo");
            Console.WriteLine("4 - Diseño Grafico");
        }
    }
    else if (universidad == true)
    {
        Console.WriteLine("Haz tomado la desicion de estudiar en la universidad, que carrera profesional te interesa? ");
        if(genero == "Masculino")
        {
            Console.WriteLine("1 - Ingenieria en Sistemas");
            Console.WriteLine("2 - Ingenieria Civil");
            Console.WriteLine("3 - Medicina");
            Console.WriteLine("4 - Derecho");
        }
        else if (genero == "Femenino")
        {
            Console.WriteLine("1 - Enfermeria");
            Console.WriteLine("2 - Arquitectura");
            Console.WriteLine("3 - Publicidad");
            Console.WriteLine("4 - Administracion");
        }
    }

    try
    {
        int respuesta = int.Parse(Console.ReadLine() ?? "0");
        if (respuesta == 1)
        {
            if (escuelaTecnica == true)
            {
                if(genero == "Masculino")
                {
                   carrera = "Programacion de Software";
                }
                if (genero == "Femenino")
                {
                    carrera = "Cosmetologia";
                }
            }
            if (universidad == true)
            {
                if (genero == "Masculino")
                {
                    carrera = "Ingenieria en Sistemas";
                }
                if (genero == "Femenino")
                {
                    carrera = "Enfermeria";
                }
            }
        }
        else if (respuesta == 2)
        {
            if (escuelaTecnica == true)
            {
                if (genero == "Masculino")
                {
                    carrera = "Mecanica Automotriz";
                }
                if (genero == "Femenino")
                {
                    carrera = "Cocina Profesional";
                }
            }
            if (universidad == true)
            {
                if (genero == "Masculino")
                {
                    carrera = "Ingenieria Civil";
                }
                if (genero == "Femenino")
                {
                    carrera = "Arquitectura";
                }
            }
        }
        else if (respuesta == 3)
        {
            if (escuelaTecnica == true)
            {
                if (genero == "Masculino")
                {
                    carrera = "Electricidad Industrial";
                }
                if (genero == "Femenino")
                {
                    carrera = "Asistente Administrativo";
                }
            }
            if (universidad == true)
            {
                if (genero == "Masculino")
                {
                    carrera = "Medicina";
                }
                if (genero == "Femenino")
                {
                    carrera = "Publicidad";
                }
            }
        }
        else if (respuesta == 4)
        {
            if (escuelaTecnica == true)
            {
                if (genero == "Masculino")
                {
                    carrera = "Carpinteria";
                }
                if (genero == "Femenino")
                {
                    carrera = "Diseño Grafico";
                }
            }
            if (universidad == true)
            {
                if (genero == "Masculino")
                {
                    carrera = "Derecho";
                }
                if (genero == "Femenino")
                {
                    carrera = "Administracion";
                }
            }
        }
        else
        {
            Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
            goto SELECCION_CARRERA;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
        goto SELECCION_CARRERA;
    }
    // FIN SELECCION CARRERA
}


// Escogio Estudiar en la universidad o escuela tecnica
if (escuelaTecnica == true || universidad == true)
{
// INICIO GRADUARSE
SELECCION_GRADUARSE:
    if(escuelaTecnica == true)
    {
        Console.WriteLine("Haz tomado la desicion de estudiar en una escuela tecnica, la carrera es corta y te gusta lo que vez, piensas en como sera ejercer tu carrera, viendo esto piensas graduarte? ");
    }
    else if (universidad == true)
    {
        Console.WriteLine("Haz tomado la desicion de estudiar en la universidad, la carrera es larga pero te gusta lo que vez y a por igual piensas en como sera ejercer tu carrera, viendo esto piensas graduarte? ");
    }
    Console.WriteLine("1 - SI");
    Console.WriteLine("2 - NO");

    try
    {
        int respuesta = int.Parse(Console.ReadLine() ?? "0");
        if (respuesta == 1)
        {
            graduarse = true;
        }
        else if (respuesta == 2)
        {
            graduarse = false;
        }
        else
        {
            Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
            goto SELECCION_GRADUARSE;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Opcion no valida, por favor seleccione una opcion viable");
        goto SELECCION_GRADUARSE;
    }
    // FIN GRADUARSE
}


// INICIO RESULTADO
Console.WriteLine("Resultado: ");
Console.WriteLine($"Genero: {genero}");
Console.WriteLine($"Termino Colegio: {terminoColegio}");
Console.WriteLine($"Universidad: {universidad}");
Console.WriteLine($"Escuela Tecnica: {escuelaTecnica}");
Console.WriteLine($"Carrera: {carrera}");
Console.WriteLine($"Graduarse: {graduarse}");
Console.WriteLine($"Resultado: {resultado}");
// FIN RESULTADO