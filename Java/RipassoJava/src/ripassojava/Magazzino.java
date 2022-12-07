package ripassojava;

public class Magazzino {

    private Prodotto[] v;
    private int c;

    public Magazzino() {
        v = new Prodotto[100];
        for (int i = 0; i < v.length; i++) {
            int numeroAcaso = (int) ((Math.random() * (4 - 1)) + 1);
            if (numeroAcaso == 1) {
                v[i] = new Prodotto("Pasta");
            } else if (numeroAcaso == 2) {
                v[i] = new Prodotto("Prosciutto");
            } else {
                v[i] = new Prodotto("Marmellata");
            }
        }
        c = 0;
    }

    public synchronized void Add(Prodotto p) {
        for (int i = 0; i < v.length; i++) {
            if (v[i] != null) {
                v[i] = p;
                break;
            }
        }
    }

    public synchronized Prodotto rimuovi() {
        Prodotto p = new Prodotto();
        if (c != 100) {
            if (v[c] != null) {
                p = v[c];
                v[c] = null;
                c++;
            }
            return p;
        }
        return null;
    }

    public String showAll() {
        String s = "";
        for (int i = 0; i < v.length; i++) {
            if(v[i] != null){
                s+=i+") "+v[i].tipo + "\n";
            }
        }
        return s;
    }

    public synchronized boolean magazzinoVuoto() {
        for (int i = 0; i < v.length; i++) {
            if (v[i] != null) {
                return false;//Scaffale non vuoto
            }
        }
        return true;//vouto
    }
}
