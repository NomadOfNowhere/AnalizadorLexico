using System;
using System.Collections.Generic;
using ProyectoAnalizadorLexico;

class Program
{
    /*
    Escribir un programa en el cual se puedan construir AFN utilizando el método de Thompson

    Menú
    -CrearBásico
    -Unir AFN's
    -Concatenar AFN's
    -Cerradura Kleen
    -Cerradura+
    -Opcional
    -Unir AFNs para analizador léxico
    -Convertir AFN a AFD
    -Analizador léxico

    */
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        bool f = true;

        while(f) {
            Console.Clear();
            Console.WriteLine("Menú - Analizador Léxico");
            Console.WriteLine("[1]. Crear Básico");
            Console.WriteLine("[2]. Unir AFN's");
            Console.WriteLine("[3]. Concatenar AFN's");
            Console.WriteLine("[4]. Cerradura Kleen");
            Console.WriteLine("[5]. Cerradura +");
            Console.WriteLine("[6]. Opcional");
            Console.WriteLine("[7]. Unir AFN's para Analizador Léxico");
            Console.WriteLine("[8]. Convertir AFN a AFD");
            Console.WriteLine("[9]. Analizador Léxico");
            Console.WriteLine("[0]. Salir");
            Console.Write("Seleccione una opción: ");
            switch(Console.ReadLine()) {
                case "1":
                    break;
                case "0":
                    break;
            }
        }
    }

}
