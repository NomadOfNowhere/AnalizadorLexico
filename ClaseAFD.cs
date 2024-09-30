using ProyectoAnalizadorLexico;
using System;
using System.Collections.Generic;

namespace ProyectoAnalizadorLexico {
    class TransEdoAFD {
        public int IdEdo;
        public int[] TransAFD;
    }

    public class AFD {
        public static HashSet<AFD> ConjAFDs = new HashSet<AFD>();
        public int[][] TransicionesAFD;
        public int idAFD;
        public int row1;
        public int column1;
        public HashSet<char> Alfabeto = new HashSet<char>();
        public int NumEstados;
        public int[,] TablaAFD;
        public int IdAFD;

        public AFD() {
            IdAFD = -1;
        }

        
        public AFD(int carEdosIj, HashSet<ConjIj> EdosAFD)
        {
            TransicionesAFD = new int[carEdosIj][];
            row1 = carEdosIj;
            column1 = 256;
            for (int i = 0; i < carEdosIj; i++)
            {
                foreach(ConjIj cIJ in EdosAFD)
                {
                    if (cIJ.Idj == i)
                    {
                        TransicionesAFD[i] = cIJ.TransicionesAFD;
                    }
                }
            }
        }

        public AFD(int NumeroDeEstados, int IdAutFD) {
            TablaAFD = new int[NumeroDeEstados, 257];
            for(int i=0; i<NumeroDeEstados; i++) {
                for(int j=0; j<257; j++){
                    TablaAFD[i, j] = -1;
                }
            }
            NumEstados = NumeroDeEstados;
            IdAFD = IdAutFD;
            AFD.ConjAFDs.Add(this);
        }

        public void GuardarAFDenArchivo(string NombArchivo) {
            
        }
    }
}