package server;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;

public class Server {

    public static void main(String[] args) throws SocketException, IOException {

        DatagramSocket server = new DatagramSocket(666);
        Rubrica rubrica = new Rubrica();
        while (true) {
            byte[] buffer = new byte[1500];
            DatagramPacket pacchetto = new DatagramPacket(buffer, buffer.length);
            server.receive(pacchetto);
            byte[] datiRicevuti = pacchetto.getData(); // copia del buffer dichiarato sopra
            String tutto = new String(datiRicevuti, 0, pacchetto.getLength());
            int scelta = Integer.parseInt(tutto.substring(0, 1)); // solo il numero della scelta
            String messaggio = "";
            if (tutto.length() > 1) {
                messaggio = tutto.substring(2); // messaggio totale in CSV
            }
            System.out.println("Scelta: " + scelta);
            System.out.println("Messaggio: " + messaggio);
            switch (scelta) {
                case 1:
                    String[] vett = messaggio.split(";");
                    Contatto c = new Contatto(vett[0], vett[1], vett[2], vett[3]);
                    rubrica.aggiungiContatto(c);
                    break;
                case 2:
                    int pos = Integer.parseInt(messaggio);
                    if (rubrica.eliminaContatto(pos) == false) {
                        invia("Errore, posizione minore di 0 o maggiore rispetto alla dimensione massima", pacchetto, server);
                    } else {
                        invia("Eliminazione avvenuta con successo", pacchetto, server);
                    }
                    break;
                case 3:
                    String risposta = rubrica.CercaContatto(messaggio);
                    if (risposta != null) {
                        invia(risposta, pacchetto, server);
                    } else {
                        invia("Errore, contatto non trovato!", pacchetto, server);
                    }
                    break;
                case 4:
                    rubrica.scriviSuFile();
                    break;
            }
        }
    }

    public static void invia(String messaggio, DatagramPacket pacchetto, DatagramSocket server) throws SocketException, IOException {
        byte[] bufRisposta = messaggio.getBytes();
        DatagramPacket pacchettoRisposta = new DatagramPacket(bufRisposta, bufRisposta.length);
        pacchettoRisposta.setAddress(pacchetto.getAddress());
        pacchettoRisposta.setPort(pacchetto.getPort());
        server.send(pacchettoRisposta);
    }

}
