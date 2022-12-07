package client;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;

public class Client {

    public static void main(String[] args) throws SocketException, IOException {
        DatagramSocket client = new DatagramSocket();
        /*
        int miaPorta = client.getLocalPort();//la GetPort riporta la porta remota, quindi uso la LocalPort
        System.out.println("Client porta: " + miaPorta);
        */
        
        String messagggio = "ciao ";
        byte[] buffer = messagggio.getBytes(); //converto la stringa in un byte di array
        DatagramPacket pacchetto = new DatagramPacket(buffer, buffer.length);
        InetAddress indirizzo = InetAddress.getByName("172.16.102.100");//imposto l'ip del ricevente
        pacchetto.setAddress(indirizzo);//lo imposto definitivamente
        pacchetto.setPort(666);//imposto la porta
        client.send(pacchetto);//invio del pacchetto

        //il server del prof ci invia una 
        byte[] buffer2 = new byte[1500];
        DatagramPacket pacchetto2 = new DatagramPacket(buffer2, buffer2.length);
        client.receive(pacchetto2);
        byte[] datiRicevuti = pacchetto2.getData(); //copia del buffer dichiarato sopra
        String messaggio = new String(datiRicevuti);
        System.out.println("Dati ricevuti: " + messaggio);
    }
    
}
