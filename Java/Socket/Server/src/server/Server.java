/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package server;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.SocketException;

/**
 *
 * @author lucid
 */
public class Server {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SocketException, IOException {

        DatagramSocket server = new DatagramSocket(666);
        while (true) {
            byte[] buffer = new byte[1500];
            DatagramPacket pacchetto = new DatagramPacket(buffer, buffer.length);

            server.receive(pacchetto);

            String indirizzoRemoto = pacchetto.getAddress().toString();
            int portaRemota = pacchetto.getPort();
            byte[] datiRicevuti = pacchetto.getData(); //copia del buffer dichiarato sopra
            String messaggio = new String(datiRicevuti);

            System.out.println("Server indirizzo: " + indirizzoRemoto);
            System.out.println("Server portaRemota: " + portaRemota);
            System.out.println("Server datiRicevuti: " + messaggio);
            
            /*
            String ris;
            if(messaggio.contains("ciao"))
                ris = "Ciao";
            else
                ris = "Addio";
            byte[] bufRisposta = ris.getBytes();
            DatagramPacket pacchettoRisposta = new DatagramPacket(bufRisposta,bufRisposta.length);
            pacchettoRisposta.setAddress(pacchetto.getAddress());
            pacchettoRisposta.setPort(pacchetto.getPort());
            */
        }
    }

}
