package server;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;

/**
 *
 * @author lucid
 */
public class SERVER {

    
    public static void main(String[] args) throws SocketException, IOException {
        DatagramSocket server = new DatagramSocket(666);//Porta in ascolto
        Cassa cassa = new Cassa();
        while(true){           
            //creo il buffer
            byte[] buffer = new byte[1500];
            //creo il pacchetto dove inserire i dati dando come parametro il buffer dove inserire i dati e la sua lunghezza
            DatagramPacket pacchetto = new DatagramPacket(buffer,buffer.length);
            //vado a ricevere i dati [! è bloccante !]
            server.receive(pacchetto);
            //vado a inserire i dati nel buffer
            buffer = pacchetto.getData();
            //inserisco tutti i dati del buffer dentro una stringa | Parametri: Il buffer, la posizione di inzio da cui leggere, la dimensione del pacchetto escludendo i campi null
            String messaggioTotale = new String(buffer,0,pacchetto.getLength());
            //serializzo il messaggio
            Serializzatore ser = Serializzatore.fromCSV(messaggioTotale);
            
            if(ser.getRichiesta().equals("ordine"))
            {
                Prodotto p = new Prodotto();
                p.fromCSV(ser.getInfo());//GET INFO contiene tutta la stringa CSV
                System.out.println(p.toString());
                cassa.addProduct(p);
            }
            else if(ser.getRichiesta().equals("scontrino"))
            {
                //System.out.print("Scontrino del cassiere: " + ser.getInfo() + " " + cassa.getScontrino(ser.getInfo()));//GET INFO contiene solo il cassiere
                sendDataToClient(cassa.getScontrino(ser.getInfo()),pacchetto,server);
            }
            else if(ser.getRichiesta().equals("start"))
            {
                String x = cassa.LeggiFileProdotti();
                sendDataToClient(x, pacchetto, server);
            }
            else
            {
                String scontrino = cassa.getScontrino(ser.getInfo()); //getInfo ha il nome del cassiere
                cassa.ScriviSuFileScontrino(ser.getInfo());
                sendDataToClient(scontrino, pacchetto, server);
            }
        }
    }

    public static void sendDataToClient(String messaggio, DatagramPacket pacchetto, DatagramSocket server) throws SocketException, IOException {
        byte[] bufRisposta = messaggio.getBytes();
        DatagramPacket pacchettoRisposta = new DatagramPacket(bufRisposta, bufRisposta.length);
        pacchettoRisposta.setAddress(pacchetto.getAddress());
        pacchettoRisposta.setPort(pacchetto.getPort());
        server.send(pacchettoRisposta);
    }
    public static void invertito(String messaggio) throws IOException {
        DatagramSocket client = new DatagramSocket();
        byte[] buffer = messaggio.getBytes(); // converto la stringa in un byte di array
        DatagramPacket pacchetto = new DatagramPacket(buffer, buffer.length);
        InetAddress indirizzo = InetAddress.getByName("localhost");// imposto l'ip del ricevente
        pacchetto.setAddress(indirizzo);// lo imposto definitivamente
        pacchetto.setPort(2222);// imposto la porta
        client.send(pacchetto);// invio del pacchetto
    }
    
}
