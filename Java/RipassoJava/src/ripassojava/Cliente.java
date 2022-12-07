package ripassojava;

import java.util.HashSet;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Cliente extends Thread {

    private int id;
    private Scaffale s;
    private int prodottiPresi;

    public Cliente(int id, Scaffale s) {
        this.id = id;
        this.s = s;
        prodottiPresi = 0;
    }

    @Override
    public void run() {
        boolean fine = false;
        while (fine == false) {
            s.rimuovi();
            prodottiPresi++;
            try {
                int dormi = (int) ((Math.random() * (300 - 100)) + 100);
                Thread.sleep(dormi);
            } catch (InterruptedException ex) {
                Logger.getLogger(Cliente.class.getName()).log(Level.SEVERE, null, ex);
            }
            if (s.ScaffaleVuoto()) {
                fine = true;
                
            }

            System.out.println(s.mostraTutto());
        }
        System.out.println("Thread cliente ha finito! " + id + " Prodotti presi: " + prodottiPresi);
    }

}
