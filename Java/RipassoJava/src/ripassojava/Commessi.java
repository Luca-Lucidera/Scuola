/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ripassojava;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author lucid
 */
public class Commessi extends Thread {

    public String nome;
    private Scaffale s;
    private Magazzino m;
    public int prodottiInseriti;

    public Commessi(String nome, Scaffale s, Magazzino m) {
        this.nome = nome;
        this.s = s;
        this.m = m;
        prodottiInseriti = 0;
    }

    @Override
    public void run() {
        boolean fine = false;
        while (fine == false) {
            int posto = s.checkPostoMancante();
            if (posto != -1) {
                Prodotto p = m.rimuovi();
                s.Add(p, posto);
                prodottiInseriti++;
                try {
                    int dormi = (int) ((Math.random() * (100 - 50)) + 50);
                    Thread.sleep(100);
                } catch (InterruptedException ex) {
                    Logger.getLogger(Commessi.class.getName()).log(Level.SEVERE, null, ex);
                }
                if (m.magazzinoVuoto() == true) {
                    System.out.println("Lo magazzino è vuoto!");
                    fine = true;
                }
            }
           
            System.out.println(m.showAll());
            
            

        }
        System.out.println("Thread commessa " + nome + " ha finito");
        s.setWinner(this); //imposta e dichiara il vincitore

    }

}
