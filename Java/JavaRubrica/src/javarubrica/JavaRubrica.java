
package javarubrica;
import java.io.IOException;
import java.util.*;
/**
 *
 * @author lucid
 */
public class JavaRubrica {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException {
        Scanner s = new Scanner(System.in);
        Rubrica r = new Rubrica();
        int scelta = -1;
        while(scelta != 4){
            System.out.println(
                      "1) Crea contatto \n"
                    + "2) Elimina contatto \n"
                    + "3) Cerca contatto per cognome \n"
                    + "4) Esci.");
            scelta = s.nextInt();
            switch(scelta){
                case 1:
                    System.out.println("Inserire il nome");
                    String nome = s.nextLine();
                    System.out.println("Inserire il cognome");
                    String cognome = s.nextLine();
                    System.out.println("Inserire il numero di telefono");
                    String telefono = s.nextLine();
                    System.out.println("Inserire la data di nascita");
                    String nascita = s.nextLine();
                    Contatto c = new Contatto(nome,cognome,telefono,nascita);
                    r.aggiungiContatto(c);
                    break;
                case 2:
                    System.out.println("Inserisci la posizione del contatto da eliminare");
                    int pos = s.nextInt();
                    r.eliminaContatto(pos);
                    break;
                case 3:
                    System.out.println("Cerca un contatto per cognome");
                    String cog = s.nextLine();
                    System.out.println(r.CercaContatto(cog));
                    break;
                    
            }
            
        }
        r.scriviSuFile();
    }
    
}
