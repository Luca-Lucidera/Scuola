/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package server;
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

    public boolean eliminaContatto(int pos) {
        if(pos < 0 || pos > l.size()){
            return false;
        }
        else{
            l.remove(pos);
            return true;
        }
    }

    public String CercaContatto(String cognome) {
        String all = "";
        for (int i = 0; i < l.size(); i++) {
            
            if (cognome.equals(l.get(i).getCognome())) {
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
        b.close();
        f.close();
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
        b.close();
        w.close();
    }
}