package javarubrica;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.*;

public class Rubrica {

    public List<Contatto> l;
    FileWriter w;
    FileReader f;

    public Rubrica() throws IOException {
        l = new ArrayList<Contatto>();
        f = new FileReader("dati.txt");
        leggiIlFile();
    }

    public void aggiungiContatto(Contatto c) throws IOException {
        l.add(c);
    }

    public void eliminaContatto(int pos) {
        l.remove(pos);
    }

    public String CercaContatto(String cognome) {
        String all = "";
        for (int i = 0; i < l.size(); i++) {
            if (cognome == l.get(i).cognome) {
                all = l.get(i).visTutto();
                return all;
            }
        }
        return null;
    }

    private void leggiIlFile() throws IOException {
        BufferedReader b;
        b = new BufferedReader(f);
        String s;
        while (true) {
            s = b.readLine();
            if (s == null) {
                break;
            }
            String[] a = new String[4];
            a = s.split(";");
            Contatto co = new Contatto(a[0], a[1], a[2], a[3]);
            aggiungiContatto(co);
        }
    }

    public void scriviSuFile() throws IOException {
         w = new FileWriter("dati.txt");
        String stringa = "";
        for (int i = 0; i < l.size(); i++) {
            stringa += l.get(i).visTutto() + "\n";   
        }
        BufferedWriter b;
        b = new BufferedWriter(w);
        b.write(stringa);
        b.flush();
    }
}
