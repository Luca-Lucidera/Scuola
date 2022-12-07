package Client;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;
import java.util.Scanner;


public class Client {
    public static void main(String[] args) throws SocketException, IOException {
        DatagramSocket client = new DatagramSocket();
        while(true)
        {
            Scanner scanner =  new Scanner(System.in);
            int numero = scanner.nextInt();
            String tmp = scanner.nextLine();
            String messaggio = Integer.toString(numero);
            //converto la stringa in un byte di array
            byte[] BufferDatiDaInviare = messaggio.getBytes(); 
           
            //creo il pacchetto dando come parametro il buffer e la sual lunghezza
            DatagramPacket pacchetto = new DatagramPacket(BufferDatiDaInviare, BufferDatiDaInviare.length);
            
            //imposto l'ip del ricevente
            InetAddress indirizzo = InetAddress.getByName("localhost");
    
            //lo imposto definitivamente
            pacchetto.setAddress(indirizzo);
    
            //imposto la porta
            pacchetto.setPort(666);
            
            //invio del pacchetto
            client.send(pacchetto);
    
            /*
                RISPOSTA DAL SERVER
            
            */
            //crea il nuovo buffer
            byte[] BufferDatiRicevuti = new byte[1500];
    
            //ricreo il pacchetto di prima però indicando che ci sarà un nuovo buffer
            pacchetto = new DatagramPacket(BufferDatiRicevuti, BufferDatiRicevuti.length);
    
            //con la recive vado a prendere il pacchetto
            client.receive(pacchetto);
    
            //copia del buffer dichiarato sopra
            BufferDatiRicevuti = pacchetto.getData(); 
            messaggio = new String(BufferDatiRicevuti);
            System.out.println("Dati ricevuti: " + messaggio);
          
        }
        
    }
}
