package server;

import java.io.*;
import java.util.ArrayList;

public class Gestore {
    private ArrayList<Dato> l;
    private FileReader reader;
    private FileWriter writer;
    public Gestore(){
        l = new ArrayList<Dato>();
    }
    public void AggiungiDato(Dato d){
        l.add(d);
    }
    public String Finalizza() {
        String array = "";
        float tempMedia = mediaTemperature();
        array = Float.toString(tempMedia)+";";
        array += Float.toString(mediaUmidita())+";";
        array += Float.toString(temperaturaMinima())+";";
        array += Float.toString(temperaturaMassima())+";";
        array += Float.toString(NtempUpperMedia(tempMedia));
        return array;
    }
    private float mediaTemperature(){
        float tmp = 0.f;
        int validi = 0;
        for (int i = 0; i < l.size(); i++) {
            if(l.get(i).getTemperatura() != -100){
                tmp+=l.get(i).getTemperatura();
                validi++;
            }
        }
        return tmp/validi;
    }
    private float mediaUmidita(){
        float tmp = 0.f;
        int validi = 0;
        for (int i = 0; i < l.size(); i++) {
            if(l.get(i).getUmidita() != -1){
                tmp+=l.get(i).getUmidita();
                validi++;
            }
        }
        return tmp/validi;
    }
    private float temperaturaMinima(){
        float val = 80;
        for (int i = 0; i < l.size(); i++) {
            float tmp = l.get(i).getTemperatura();
            if(tmp < val && tmp != -100){
                val = tmp;
            }
        }
        return val;
    }
    private float temperaturaMassima(){
        float val = -80;
        for (int i = 0; i < l.size(); i++) {
            float tmp = l.get(i).getTemperatura();
            if(tmp > val && tmp != -100){
                val = tmp;
            }
        }
        return val;
    }
    private float NtempUpperMedia(float Tmedia){
        int c = 0;
        for (int i = 0; i < l.size(); i++) {
            float tmp = l.get(i).getTemperatura();
            if(tmp > Tmedia && tmp != -100){
                c++;
            }
        }
        return c;
    }
    public void scriviFile() throws IOException{
        writer = new FileWriter("dati.txt", true);
        BufferedWriter w = new BufferedWriter(writer);
        String csv = "";
        for (int i = 0; i < l.size();i++){
            csv += l.get(i).toCsv() + "\n";
        }
        w.write(csv);
        w.flush();
        w.close();
    }
}
