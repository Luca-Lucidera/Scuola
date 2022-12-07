/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package server;

/**
 *
 * @author lucid
 */
public class Dato {
    private float temperatura;
    private float umidita;
    public Dato(){
        temperatura = -100; // se -100 vuol dire nulla
        umidita = -1; //se -1 vuol dire nulla
    }
    public Dato(float temperatura, float umidita) {
        this.temperatura = temperatura;
        this.umidita = umidita;
    }
    public void setTemperatura(float temperatura) {
        this.temperatura = temperatura;
    }
    public void setUmidita(float umidita) {
        this.umidita = umidita;
    }
    public float getTemperatura() {
        return temperatura;
    } 
    public float getUmidita() {
        return umidita;
    }
    @Override
    public String toString() {
        return "Dato [temperatura=" + temperatura + ", umidita=" + umidita + "]";
    }
    public String toCsv(){
        return temperatura + ";"+ umidita;
    }
    public int FromCSV(String csv){
        String[] dati = csv.split(";");
        float tempe = Float.parseFloat(dati[0]);
        float um = Float.parseFloat(dati[1]);
        boolean cT = false, cU = false;
        //controllo temperatura
        if(tempe >= -80 && tempe <= 80){
            setTemperatura(tempe);
            cT = true;
        }
        if(um >= 0 && um <= 100){
            setUmidita(um);
            cU = true;
        }
        if(cT == false && cU == false) //cannate temperatura e umidita
            return -4;
        else if( cT == false || cU == false){
            if(cT == false){
                setTemperatura(-100); //nulla
                return -2;
            }
            else{
                setUmidita(-1);//umidità a -1 è nulla
                return -1;
            }
        } 
        else //tutto appostolo
            return 1;

    }
}
