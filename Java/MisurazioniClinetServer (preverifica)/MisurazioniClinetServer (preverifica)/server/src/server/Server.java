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
     * @throws IOException
     */
    public static void main(String[] args) throws IOException {
        Gestore g = new Gestore();
        DatagramSocket server = new DatagramSocket(12345);
        while (true) {
            
            byte[] buffer = new byte[1500];
            DatagramPacket packet = new DatagramPacket(buffer, buffer.length);
            String csv = ricevi(server,packet);

            Serializzatore ser = Serializzatore.FromCsv(csv);
            if (ser.getScelta().equals("salva")) {
                Dato d = new Dato();
                int check = d.FromCSV(ser.getMessaggio());
                System.out.println("Temperatura: " + d.getTemperatura() +" Umidita: " + d.getUmidita());
                if (check == 1) {
                    g.AggiungiDato(d);
                    sendData("dati inseriti correttamente",server,packet);
                } else if (check == -1) {
                    g.AggiungiDato(d);
                    sendData("Dato salvato, umidità errata",server,packet);
                } else if (check == -2) {
                    g.AggiungiDato(d);
                    sendData("Dato salvato, temperatura errata",server,packet);
                } else {
                    sendData("Dato non salvato, entrambi i dati sono errati!",server,packet);
                }
            }
            else
            {
                String mess =  g.Finalizza();
                g.scriviFile();
                sendData(mess, server, packet);
            }
        }

    }

    public static String ricevi(DatagramSocket server, DatagramPacket packet) throws IOException {
        server.receive(packet);
        byte[] dataReceived = packet.getData(); // copia del buffer dichiarato sopra
        String messaggioRicevuto = new String(dataReceived, 0, packet.getLength());
        return messaggioRicevuto;
    }

    public static void sendData(String risposta, DatagramSocket server, DatagramPacket packet) throws IOException {
        byte[] responseBuffer = risposta.getBytes();
        DatagramPacket responsePacket = new DatagramPacket(responseBuffer, responseBuffer.length);
        responsePacket.setAddress(packet.getAddress());
        responsePacket.setPort(packet.getPort());
        server.send(responsePacket);
    }

}
