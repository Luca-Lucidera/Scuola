package verifica_lucidera;

import java.io.IOException;
import java.util.Scanner;
import ws.WS;

/**
 *
 * @author lucidera_luca
 */
public class Verifica_Lucidera {

    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        String input = "";
        WS ws = new WS();
        String token = "";
        String key = "citta";
        int c = 1;
        boolean risultato = false;
        while ((!input.equals("l") && !input.equals("r")) || risultato == false) {
            System.out.println("r -> registrati | l -> login");
            input = scanner.next();

            System.out.println("Username:");
            String username = scanner.next();
            System.out.println("Passwrd");
            String password = scanner.next();

            if (input.equals("l")) {
                token = ws.login(username, password); //ritorna il token
                if (!token.equals("false")) {
                    risultato = true;
                } else {
                    token = "";
                    risultato = false;
                }
            } else if (input.equals("r")) {
                risultato = ws.registrati(username, password);
                if (risultato) {
                    token = ws.login(username, password);
                }
            }
        }
        System.out.println("Token: " + token);
        c = ws.getLastCounter(token);
        int scelta = -1;
        while (scelta != 0) {
            System.out.println(
                    "1) inserisci tappa\n"
                    + "2) visualizza lista tappe\n"
                    + "3) rimuovi tappa\n"
                    + "4) inverti tappe\n"
                    + "5) calcola distanza itinerario\n"
                    + "6) cancella itinerario\n"
                    + "0) esci");
            scelta = scanner.nextInt();
            scanner.next();
            switch(scelta){
                case(1) ->{
                    System.out.println("inserisci una Citta");
                   
                    String stringa = scanner.nextLine();
                    key = key+c;
                    if(ws.inserisciTappa(token, key, stringa, c)){
                        System.out.println("tappa inserita");
                        c++;
                    }
                    else{
                        System.out.println("Tappa non inserita");
                    }
                    key = "citta";
                }
                case(2) ->{
                    //String all = ws.listaTappe();
                }
                case(3) ->{
                    
                }
                case(4) ->{
                    
                }
                case(5) ->{
                    
                }
                case(6) ->{
                    
                }
            }
        }
    }

}
