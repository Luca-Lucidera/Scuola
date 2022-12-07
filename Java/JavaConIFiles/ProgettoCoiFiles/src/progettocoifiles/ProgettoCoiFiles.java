package progettocoifiles;

import java.io.*;

public class ProgettoCoiFiles {

    //Funzione per vedere se un file esiste
    public static void esisteIlFile() {

        File f;
        f = new File("dati//abcd.txt");

        if (f.exists()) {
            System.out.println("Il file abcd.txt esiste");
        } else {
            System.out.println("Il file abcd.txt non esiste");
        }

    }
    public static void esisteIlFile2() throws IOException {
    File f;
    f=new File("prova.txt");

    if(f.exists()) {
      File g;
      g=new File("altro.txt");

      f.renameTo(g);

      File h;
      h=new File("prova2.txt");

      h.delete();
    }
  }
    
    public static void main(String[] args) throws IOException {
        //esisteIlFile();
        esisteIlFile2();
    }

}
