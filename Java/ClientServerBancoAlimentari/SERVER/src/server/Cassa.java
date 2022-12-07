package server;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;


public class Cassa {
    private ArrayList<Prodotto> lista;
    private FileReader reader;
    private FileWriter writer;

    public Cassa()throws IOException{
        lista = new ArrayList<Prodotto>();
    }
    public void addProduct(Prodotto p){
        lista.add(p);
    }
    @Override
    public String toString(){
        String s = "";
        for (int i = 0; i < lista.size(); i++) {
            s+=lista.get(i).toString() + "\n";
        }
        return s;
    }
    public String getScontrino(String cassiere){
        String s = "";
        float parziale = 0.f;
        for (int i = 0; i < lista.size(); i++) {
            if(lista.get(i).getCassiere().equals(cassiere)){
                parziale += lista.get(i).getPrezzo() * lista.get(i).getQuantita();
            }
        }
        s = "Cassiere: " + cassiere + " " + Float.toString(parziale);
        return s;
    }
    public void ScriviSuFileScontrino(String info) throws IOException {
        writer = new FileWriter("dati.txt",true);//il true è per aprire il file in append
        String stringa = "";
        for (int i = 0; i < lista.size(); i++) {
            if(lista.get(i).getCassiere().equals(info)){
                stringa += lista.get(i).toCSV() + "\n";
            }
        }
        BufferedWriter b;
        b = new BufferedWriter(writer);
        b.write(stringa);
        b.flush();
        b.close();
        writer.close();
        if(stringa != ""){
            TogliElementiDelCassiere(info);
        }
        
    }
    private void TogliElementiDelCassiere(String info) {
        for (int i = 0; i < lista.size(); i++) {
            if(lista.get(i).getCassiere().equals(info)){
                lista.remove(i);
                i--;
            }
        }
    }

    public String LeggiFileProdotti() throws IOException{
        String prodottiCSV = "";
        reader = new FileReader("prodotti.txt");
        BufferedReader b;
        b = new BufferedReader(reader);
        String s;
        while (true) {
            s = b.readLine();
            if (s == null) {
                break;
            }
            prodottiCSV += s + "\n";
        }
        b.close();
        reader.close();
        return prodottiCSV;
    }
}
