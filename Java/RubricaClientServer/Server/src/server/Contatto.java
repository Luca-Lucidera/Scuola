/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package server;

/**
 *
 * @author lucid
 */
public class Contatto {
    public String nome;
    public String cognome;
    public String telefono;
    public String dataNascita;

    public Contatto(String nome, String cognome, String telefono, String dataNascita) {
        this.nome = nome;
        this.cognome = cognome;
        this.telefono = telefono;
        this.dataNascita = dataNascita;
    }

    public String getNome() {
        return nome;
    }

    public String getCognome() {
        return cognome;
    }

    public String getTelefono() {
        return telefono;
    }

    public String getDataNascita() {
        return dataNascita;
    }
    public String visTutto(){
        return nome + ";" + cognome + ";" + dataNascita + ";" + dataNascita;
    }
}
