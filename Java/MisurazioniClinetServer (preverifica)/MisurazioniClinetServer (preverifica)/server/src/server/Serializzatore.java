package server;

public class Serializzatore {
    private String scelta;
    private String messaggio;
    public Serializzatore(String scelta, String messaggio){
        this.scelta = scelta;
        this.messaggio = messaggio;
    }
    public void setScelta(String scelta) {
        this.scelta = scelta;
    }
    public void setMessaggio(String messaggio) {
        this.messaggio = messaggio;
    }
    public String getScelta() {
        return scelta;
    }
    public String getMessaggio() {
        return messaggio;
    }
    public static Serializzatore FromCsv(String csv){
        int indice = csv.indexOf(";");
        String scelta = csv.substring(0, indice);
        String messaggio = csv.substring(indice + 1, csv.length());
        return new Serializzatore(scelta, messaggio);
    }
}
