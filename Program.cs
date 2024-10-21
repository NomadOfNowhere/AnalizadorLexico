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
                    crearBasico();
                    break;
                case "0":
                    break;
            }
        }
    }

    public static void crearBasico() {
        string inf = Console.ReadLine();
        string sup = Console.ReadLine();
        int id = Convert.ToInt32(Console.ReadLine());


        AFN afn = new AFN();

        if(inf[0] == sup[0]) {
            afn.CrearAFNBasico(inf[0]);
        }
        else {
            afn.CrearAFNBasico(inf[0], sup[0]);
        }
    }
/*
    MessageBox.Show("Se usa lo que ingresa", "Aviso");
                //Recuperamos los datos del formulario
                string caracterInf = Caracter_Inf.Text;
                string caracterSup = Caracter_Sup.Text;
                int id = Convert.ToInt32(ID_AFND.Text);

                char C_Inf = caracterInf[0];
                char C_Sup = caracterSup[0];
                AFND afnd = new AFND();

                if (C_Inf == C_Sup)
                {
                    //Solo se toma el caracter inferior
                    //Creamos el AFND
                    afnd.CrearAFNDBasico(C_Inf, id);
                    //Lo añadimos a la lista
                    ListAFND.Add(afnd);
                    //reseteamos el formulario
                    ResetFormBasic();
                    //mostramos el AFND
                    afnd.MostrarAFND();

                }
                else
                {
                    //Creamos el AFND
                    afnd.CrearAFNDBasico(C_Inf, C_Sup, id);
                    //Lo añadimos a la lista
                    ListAFND.Add(afnd);
                    //reseteamos el formulario
                    ResetFormBasic();
                    //mostramos el AFND
                    afnd.MostrarAFND();

                }
*/
}
