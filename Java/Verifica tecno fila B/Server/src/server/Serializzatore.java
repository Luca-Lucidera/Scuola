/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package server;

/**
 *
 * @author lucidera_luca
 */
public class Serializzatore {
    private String scelta;
    private String dato;

    public Serializzatore(String scelta, String dato) {
        this.scelta = scelta;
        this.dato = dato;
    }

    public void setDato(String dato) {
        this.dato = dato;
    }

    public void setScelta(String scelta) {
        this.scelta = scelta;
    }

    public String getDato() {
        return dato;
    }

    public String getScelta() {
        return scelta;
    }
    public static Serializzatore fromCSV(String csv){
        int index = csv.indexOf(";");
        String scelta = csv.substring(0, index);
        String dato = csv.substring(index+1, csv.length());
        return new Serializzatore(scelta,dato);
    }
}
