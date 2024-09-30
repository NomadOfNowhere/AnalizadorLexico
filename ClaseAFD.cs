class TransEdoAFD {
    public int IdEdo;
    public int[] TransAFD;
}

public class AFD {
    public static HashSet<AFD> ConjAFDs = new HashSet<AFD>();
    public HashSet<char> Alfabeto = new HashSet<char>();
    public int NumEstados;
    public int[,] TablaAFD;
    public int IdAFD;

    public AFD() {
        IdAFD = -1;
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