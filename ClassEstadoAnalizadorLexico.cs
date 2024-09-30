using ProyectoAnalizadorLexico;
using System;
using System.Collections.Generic;

namespace ProyectoAnalizadorLexico {
    class ClassEstadoAnalizLexico
    {
        public int EdoActual;
        public int token;
        public char CaracterActual;
        public Stack<int> Pila;
        public int EdoTransicion;
        public int FinLexema;
        public int IndiceCaracterActual;
        public int IniLexema;
        public string Lexema;
        public bool PasoPorEdoAcept;
    }
}