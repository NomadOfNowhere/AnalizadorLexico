using ProyectoAnalizadorLexico;
using System;
using System.Collections.Generic;

namespace ProyectoAnalizadorLexico {
        public class ConjIj {
        public int j;
        public HashSet<Estado> ConjI;
        public int[] TransicionesAFD;

        public ConjIj(int CardAlf) {
            j = -1;
            ConjI = new HashSet<Estado>();
            ConjI.Clear();

            TransicionesAFD = new int[CardAlf+1];

            for(int k = 0; k <= CardAlf; k++) {
                TransicionesAFD[k] = -1;
            }
        }
    }

    public class AFN {
        public static HashSet<AFN> ConjDeAFNs = new HashSet<AFN>();
        Estado EdoIni;
        HashSet<Estado> EdosAFN = new HashSet<Estado>();
        HashSet<Estado> EdosAcept = new HashSet<Estado>();
        HashSet<char> Alfabeto = new HashSet<char>();
        bool SeAgregoAFNUnionLexico;
        public int IdAFN;

        public AFN() {
            IdAFN = 0;
            EdoIni = null;
            EdosAFN.Clear();
            EdosAcept.Clear();
            Alfabeto.Clear();
            SeAgregoAFNUnionLexico = false;
        }

        public AFN CrearAFNBasico(char s) {
            Transicion t;
            Estado e1, e2;
            e1 = new Estado();
            e2 = new Estado();
            t = new Transicion(s, e2);
            e1.Trans.Add(t);
            e2.EdoAcept = true;
            _ = Alfabeto.Add(s);
            EdoIni = e1;
            _ = EdosAFN.Add(e1);
            _ = EdosAFN.Add(e2);
            _ = EdosAcept.Add(e2);
            SeAgregoAFNUnionLexico = false;
            return this;
        }

        public AFN CrearAFNBasico(char s1, char s2) {
            // Se debe validar que s1 <= se
            char i;
            Transicion t;
            Estado e1, e2;
            e1 = new Estado();
            e2 = new Estado();
            t = new Transicion(s1, s2, e2);
            _ = e1.Trans.Add(t);
            e2.EdoAcept = true;

            for(i = s1; i<= s2; i++) {
                _ = Alfabeto.Add(i);
            }
            EdoIni = e1;
            _ = EdosAFN.Add(e1);
            _ = EdosAFN.Add(e2);
            _ = EdosAcept.Add(e2);
            SeAgregoAFNUnionLexico = false;
            return this;
        }

        public AFN UnirAFN(AFN f2) {
            Estado e1 = new Estado();
            Estado e2 = new Estado();
            // el estado tendrá dos transiciones epsilon, una al edo inicial del afn this, ???
            Transicion t1 = new Transicion(SimbolosEspeciales.EPSILON, this.EdoIni);
            Transicion t1 = new Transicion(SimbolosEspeciales.EPSILON, f2.EdoIni);
            _ = e1.Trans.Add(t1);
            _ = e1.Trans.Add(t2);

            /*
                Ahora cada estado de aceptación de this y de f2 tendrá una transición
                los que eran estados de aceptación de this, ya no serán de aceptación
                los que eran estados de aceptación de f2, ua no serán de aceptación
            */
            foreach(Estado e in this.EdosAcept) {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e2));
                _ = e.EdoAcept = false;
            }
            foreach(Estado e in f2.EdosAcept) {
                _ = e.Trans.Add(new Transicion(simbolosEspeciales.EPSILON), e2);
                _ = e.EdoAcept = false;
            }

            /*
                Ahora e2 es el estado de aceptación
                Se actualiza la inf del nuevo autómata this
            */
            this.EdosAcept.Clear();
            f2.EdosAcept.Clear();
            this.EdoIni = e1;
            e2.EdoAcept = true;
            this.EdosAcept.Add(e2);
            this.EdosAFN.UnionWith(f2.EdosAFN);
            this.EdosAFN.Add(e1);
            this.EdosAFN.Add(e2);
            this.AlfabetoUnionWith(f2.Alfabeto);
            return this;
        }

        public AFN ConcAfn(AFN f2) {
            /*
                En la operación de concatenación se fusionan el estado de aceptación
                Conservaremos el estado de aceptación de this
            */
            foreach(Transicion t in f2.EdoIni.Trans) {
                foreach(Estado e in this.EdosAcept) {
                    e.Trans.Add(t);
                    e.EdoAcept = false; // los edos de aceptación de this, dejan de
                }
            }
            // Ahora hay que eliminar el estado inicial de f2, de la colección de estados
            f2.EdosAFN.Remove(f2.EdoIni);
            // Actualizamos la inf del nuevo automata resultado dela concatenación
            this.EdosAcept = f2.EdosAcept;
            this.EdosAFN.UnionWith(f2.EdosAFN);
            this.Alfabeto.UnionWith(f2.Alfabeto);

            return this;
        }

        public AFN CerrPos() {
            // Se crea un nuevo edo inicial y un nuevo edo de aceptación
            Estado e_ini = new Estado();
            Estado e_fin = new Estado();

            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
            foreach(Estado e in EdosAcept) {
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
                e.EdoAcept = false;
            }

            EdoIni = e_ini;
            e_fin.EdoAcept = true;
            EdosAcept.Clear();
            EdosAcept.Add(e_fin);
            EdosAFN.Add(e_ini);
            EdosAfn.Add(e_fin);
            return this;
        }

        public AFN CerrKleen() {
            // Se crea un nuevo edo inicial y un nuevo edo  de aceptación
            Estado e_ini = new Estado();
            Estado e_fin = new Estado();

            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));

            foreach(Estado e in EdosAcept) {
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
                e.EdoAcept = false;
            }

            EdoIni = e_ini;
            e_fin.EdoAcept = true;
            EdosAcept.Clear();
            EdosAcept.Add(e_fin);
            EdosAFN.Add(e_ini);
            EdosAFN.Add(e_fin);

            return this;
        }

        public AFN Opcional() {
            // Se crea un nuevo edo inicial y un nuevo edo de aceptación
            Estado e_ini = new Estado();
            Estado e_fin = new Estado();

            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));

            foreach(Estado e in EdosAcept) {
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
                e.EdoAcept = false;
            }

            EdoIni = e_ini;
            e_fin.EdoAcept = true;
            EdosAcept.Clear();
            EdosAcept.Add(e_fin);
            EdosAFN.Add(e_ini);
            EdosAFN.Add(e_fin);

            return this;
        }

        public HashSet<Estado> CerraduraEpsilon(Estado e) {
            HashSet<Estado> R = new HashSet<Estado>();
            Stack<EStado> S = new Stack<Estado>();
            Estado aux, Edo;

            R.Clear();
            S.Clear();

            S.Push(e);

            while(S.Count != 0) {
                aux = S.Pop();
                R.Add(aux);

                foreach(Transicion t in aux.Trans) {
                    if((Edo = T.GetEdoTRans(SimbolosEspeciales.EPSILON)) != null) {
                        if(!R.Contains(Edo)) {
                            S.Push(Edo);
                        }
                    }
                }
            }
            return R;
        }

        public HashSet<Estado> CerraduraEpsilon(HashSet<Estado> ConjEdos) {
            HashSet<Estado> R = new HashSet<Estado>();
            Stack<Estado> S = new Stack<Estado>();
            Estado aux, Edo;

            R.Clear();
            S.Clear();

            foreach(Estado e in ConjEdos) {
                S.Push(e);
            }

            while(S.Count != 0) {
                aux = S.Pop();
                R.Add(aux);
                foreach(Transicion t in aux.Trans) {
                    if((Edo = t.GetEdoTrans(SimbolosEspeciales.EPSILON)) != null) {
                        if(!R.COntains(Edo)) {
                            S.Push(Edo);
                        }
                    }
                }
            }

            return R;
        }

        public HashSet<Estado> Mover(HashSet<Estado> Edos, char Simb) {
            HashSet<Estado> C = new HashSet<Estado>();
            Estado Aux;
            C.Clear();

            foreach(Estado Edo in Edos) {
                foreach(Transicion t in Edo.Trans) {
                    Aux = t.GetEdoTRans(Simb);
                    if(Aux != null) {
                        C.Add(Aux);
                    }
                }
            }

            return C;
        }
        
        public HashSet<Estado> Ir_A(HashSet<Estado> Edos, char Simb) {
            HashSet<Estado> C = new HashSet<Estado>();
            C.Clear();
            C = CerraduraEpsilon(ConjEdos: Mover(Edos, Simb));
            return C;
        }

        public void UnionEspecialAFNs(AFN f, int Token) {
            Estado e;
            if(!this.SeAgregoAFNUnionLexico) {
                this.EdosAFN.Clear();
                this.EdosAFN.Clear();
                this.Alfabeto.Clear();

                e = new Estado();
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, f.EdoIni));

                this.EdoIni = e;
                this.EdosAFN.Add(e);
                this.SeAgregoAFNUnionLexico = true;
            }
            else {
                this.EdoIni.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, f.EdoIni));
            }

            foreach(Estado EdoAcep in f.EdosAcept) {
                EdoAcep.Token = Token;

                this.EdosAcept.UnionWith(f.EdosAcept);
                this.EDosAFN.UnionWith(f.EdosAFN);
                this.Alfabeto.UnionWith(f.Alfabeto);
            }
        }

        private int IndiceCaracter(char[] ArregloAlfabeto, char c) {
            int i;
            for(i = 0; i < ArregloAlfabeto.Length; i++) {
                if(ArregloAlfabeto[i] == c) {
                    return i;
                }
            }
            return -1;
        }

        public AFD ConvAFNaAFD() {
            int CardAlfabeto, NumEdosAFD;
            int i, j, r;
            char[] ArrAlfabeto;
            ConIj Ij, Ik;
            bool existe;

            HashSet<Estado> ConjAux = new HashSet<Estado>();
            HashSet<ConIj> EdosAFD = new HashSet<ConjIj>();
            Queue<ConjIj> EdosSinAnalizar = new Queue<ConIj>();

            EdosAFD.Clear();
            EdosSinAnalizar.Clear();

            CardAlfabeto = Alfabeto.Count;
            ArrAlfabeto = new char[CardAlfabeto];

            i = 0;
            foreach(char c in Alfabeto) {
                ArrAlfabeto[i++] = c;
            }

            j = 0;    // Contador para los estados del AFD
            Ij = new ConIj(CardAlfabeto) {
                ConjI = CerraduraEpsilon(this.EdoIni),
                j = j
            };

            EdosAFD.Add(Ij);
            EdosSinAnalizar.Enqueue(Ij);
            j++;

            while(EdosSinAnalizar.Count != 0) { // mientras se tengan estados Ij sin analizar
                Ij = EdosSinAnalizar.Dequeue();

                // Calcular el IrA del Ij con cada simbolo del alfabeto
                foreach(char c in ArrAlfabeto) { // El foreach sobre un arreglo, procesa los
                    Ik = new ConjIj(CardAlfabeto) {
                        ConjI = Ir_A(Ij.ConjI, c)
                    };

                    if(Ik.ConjI.Count == 0) { // Si el conjunto fue vacío (No hubo transiciones)
                        continue;
                    }

                    // Revisemos si el Conjunto de estados ya existe, en caso será
                    existe = false;
                    foreach(ConjIj I in EdosAFD) {
                        if(I.ConjI.SetEquals(Ik.ConjI)) {
                            existe = true;
                            /*
                                El conjunto ya existe. Entonces la transición de
                                Alfabeto       - - - - - - - c - - - - - -
                                Indice columna 0 1 2 3 . . . r . . . . . .
                                Estado   Ij.j  - - - - - - - I.j - - - - - -
                                Hay que obtener el indice r de la columna del
                            */
                            r = IndiceCaracter(ArrAlfabeto, c);
                            IJ.TransicionesAFD[r] = I.j;
                            break;
                        }
                    }

                    if(!existe) {
                        Ik.j = j;
                        r = IndiceCaracter(ArrAlfabeto, c);
                        Ij.TransicionesAFD[r] = Ik.j;
                        EdosAFD.Add(Ik);
                        EdosSinAnalizar.Enqueue(Ik);
                        j++;
                    }
                }
            }

            NumEdosAFD = j;
        }
    }
}