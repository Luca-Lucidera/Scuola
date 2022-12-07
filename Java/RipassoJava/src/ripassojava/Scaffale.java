package ripassojava;

public class Scaffale {

    private Prodotto[] v;
    private Commessi[] winner;
    private int c;

    public Scaffale() {
        v = new Prodotto[50];
        winner = new Commessi[3];
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

    public synchronized void Add(Prodotto p, int pos) {
        v[pos] = p;
    }
    public synchronized void setWinner(Commessi c){
        winner[this.c] = c;
        this.c++;
        if( this.c == 3){
            dichiaraVincitore();
        }
    }
    public synchronized void rimuovi() {
        boolean fatto = false;
        if (ScaffaleVuoto() == false) {
            do {
                int numeroAcaso = (int) ((Math.random() * 50));
                if (v[numeroAcaso] != null) {
                    v[numeroAcaso] = null;
                    fatto = true;
                }
            } while (fatto == false);
        }

    }

    public synchronized int checkPostoMancante() {
        for (int i = 0; i < v.length; i++) {
            if (v[i] == null) {
                return i;//Scaffale vuoto
            }
        }
        return -1;//ci sono ancora dei prodotti
    }

    public synchronized boolean ScaffaleVuoto() {
        for (int i = 0; i < v.length; i++) {
            if (v[i] != null) {
                return false;//Scaffale non vuoto
            }
        }

        return true;//vouto
    }

    public String mostraTutto() {
        String s = "";
        for (int i = 0; i < v.length; i++) {
            if (v[i] != null) {
                s += i + ") " + v[i].tipo + "\n";
            }
        }
        return s;
    }

    private void dichiaraVincitore() {
        int max = winner[0].prodottiInseriti;
        String nome = winner[0].nome;
        for (int i = 0; i < winner.length; i++) {
            if(winner[i].prodottiInseriti > max){
                max = winner[i].prodottiInseriti;
                nome = winner[i].nome;
            }
        }
        System.out.println("Il vincitore è: " + nome + "\nProdotti insertiti: "+ max);
    }
}
