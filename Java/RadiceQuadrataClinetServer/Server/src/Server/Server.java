
import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;

public class Server {
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

            System.out.println("Server datiRicevuti: " + messaggio);
            
            //RISPOSTA DEL SERVER
            double radice = Math.sqrt(Double.parseDouble(messaggio));
            String ris = Double.toString(radice);
            byte[] bufRisposta = ris.getBytes();
            DatagramPacket pacchettoRisposta = new DatagramPacket(bufRisposta,bufRisposta.length);
            pacchettoRisposta.setAddress(pacchetto.getAddress());
            pacchettoRisposta.setPort(pacchetto.getPort());
            server.send(pacchettoRisposta);
            
        }
    }
}
