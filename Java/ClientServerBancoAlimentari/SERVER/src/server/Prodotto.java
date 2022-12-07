package server;

public class Prodotto {
    private String cassiere;
    private String tipo;
    private float prezzo;
    private int quantita;

    public Prodotto(){
        cassiere = "";
        tipo = "";
        prezzo = 0;
    }
    public Prodotto(String cassiere, String tipo, float prezzo, int quantita) {
        this.cassiere = cassiere;
        this.tipo = tipo;
        this.prezzo = prezzo;
        this.quantita = quantita;
    }

    public float getPrezzo() {
        return prezzo;
    }
    public int getQuantita() {
        return quantita;
    }
    public void setPrezzo(float prezzo) {
        this.prezzo = prezzo;
    }
    public String getCassiere() {
        return cassiere;
    }

    public void setCassiere(String cassiere) {
        this.cassiere = cassiere;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }
    public void setQuantita(int quantita) {
        this.quantita = quantita;
    }
    @Override
    public String toString() {
        return "cassiere=" + cassiere + ", tipo=" + tipo+", prezzo=" + prezzo + ", quantita=" + quantita;
    }
    public void fromCSV(String csv){
        String[] tmp = csv.split(";");
        setCassiere(tmp[0]);
        setTipo(tmp[1]);
        setPrezzo(Float.parseFloat(tmp[2]));
        setQuantita(Integer.parseInt(tmp[3]));
        
    }
    public String toCSV() {
        String csv = "";
        csv = cassiere +";" + tipo + ";" +prezzo + ";" + quantita;
        return csv;
    }    
}
