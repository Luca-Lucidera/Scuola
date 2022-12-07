/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package MyLibrary;

/**
 *
 * @author lucid
 */
public class Messaggio {
    String scelta;
    String dato;

    public Messaggio(String scelta, String dato) {
        this.scelta = scelta;
        this.dato = dato;
    }
    public String toCSV(){
        return scelta+";"+dato;
    }
    public static Messaggio fromCSV(String s){
        int indice = s.indexOf(";");
        String scelta = s.substring(0,indice);
        String messaggio = s.substring(indice + 1, s.length());
        return new Messaggio(scelta, messaggio);
    }
}
