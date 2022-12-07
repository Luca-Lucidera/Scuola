package client;

import MyLibrary.Messaggio;
import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;
import java.util.Scanner;

public class Client {

    public static void main(String[] args) throws IOException {
        DatagramSocket client = new DatagramSocket();
        Scanner scanner = new Scanner(System.in);
        String messaggio = "";
        int scelta = -1;
        while (scelta != 4) {
            System.out.println("1: Inserisci contatto\n" + "2: Elimina contatto 0 ->N\n"
                    + "3: Cerca un contatto per cognome\n" + "4: Termina il programma");
            scelta = scanner.nextInt();
            scanner.nextLine();
            switch (scelta) {
                case 1:
                    System.out.println("Inserire il nome");
                    String nome = scanner.nextLine();
                    System.out.println("Inserire il cognome");
                    String cognome = scanner.nextLine();
                    System.out.println("Inserire il la data di nascita");
                    String nascita = scanner.nextLine();
                    System.out.println("Inserire il telefono");
                    String telefono = scanner.nextLine();
                    String tmp = nome + ";" + cognome + ";" + nascita + ";" + telefono;
                    Messaggio m = new Messaggio(Integer.toString(scelta),tmp);
                    invia(m.toCSV(),client);
                    break;
                case 2:
                    System.out.println("Inserire la posizione da eliminare 0 -> N");
                    String pos = scanner.nextLine();
                    messaggio = scelta + ";" + pos;
                    invia(messaggio,client);
                    ricevi(client);
                    break;
                case 3:
                    System.out.println("Inserire il cognome da ricercare");
                    String c = scanner.nextLine();
                    messaggio = scelta + ";" + c;
                    invia(messaggio,client);
                    ricevi(client);
                    break;
                case 4:
                    messaggio = Integer.toString(scelta);
                    invia(messaggio,client);
                    break;
            }

        }
    }

    public static void invia(String messaggio, DatagramSocket client) throws SocketException, IOException {

        byte[] buffer = messaggio.getBytes(); // converto la stringa in un byte di array
        DatagramPacket pacchetto = new DatagramPacket(buffer, buffer.length);
        InetAddress indirizzo = InetAddress.getByName("localhost");// imposto l'ip del ricevente
        pacchetto.setAddress(indirizzo);// lo imposto definitivamente
        pacchetto.setPort(666);// imposto la porta
        client.send(pacchetto);// invio del pacchetto
    }

    public static void ricevi(DatagramSocket client) throws SocketException, IOException {
            byte[] BufferDatiRicevuti = new byte[1500];
            DatagramPacket pacchetto = new DatagramPacket(BufferDatiRicevuti, BufferDatiRicevuti.length);
            client.receive(pacchetto);
            BufferDatiRicevuti = pacchetto.getData(); 
            String messaggio = new String(BufferDatiRicevuti);
            System.out.println("Dati ricevuti: " + messaggio);
    }

}
