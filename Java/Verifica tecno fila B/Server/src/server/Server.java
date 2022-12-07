package server;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.SocketException;

public class Server {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SocketException, IOException {
        DatagramSocket server = new DatagramSocket(12345);
        
        Lista l = new Lista();
        while (true) {
            byte[] buffer = new byte[1500];
            DatagramPacket packet = new DatagramPacket(buffer, buffer.length);
            String csv = riceviDati(server,packet);
            Serializzatore s = Serializzatore.fromCSV(csv);
            if (s.getScelta().equals("invia")) {
                String[] scelte = s.getDato().split(";");
                String errore = "";
                if (l.aggiugniClasse(scelte[0])) {
                    errore += "Rapp di classe aggiunto correttamente ";
                } else {
                    errore += "Rapp di classe non esistente ";
                }
                if (l.aggiugniIstituto(scelte[1])) {
                    errore += "Rapp d'istituto aggiunto correttamente";
                } else {
                    errore += "Rapp d'istituto non esistente";
                }
                sendData(server, packet ,errore);
            }
            else
            {
                String vincitori = l.checkWinner();
                sendData(server, packet, vincitori);
            }
        }

    }

    private static String riceviDati(DatagramSocket server,DatagramPacket packet) throws IOException {
        server.receive(packet);
        byte[] dataReceived = packet.getData(); // copia del buffer dichiarato sopra
        String messaggioRicevuto = new String(dataReceived, 0, packet.getLength());
        return messaggioRicevuto;
    }

    private static void sendData(DatagramSocket server, DatagramPacket packet,String risposta) throws IOException {
        byte[] responseBuffer = risposta.getBytes();

        DatagramPacket responsePacket = new DatagramPacket(responseBuffer, responseBuffer.length);

        responsePacket.setAddress(packet.getAddress());

        responsePacket.setPort(packet.getPort());

        server.send(responsePacket);
    }

}
