package server;

public class Serializzatore {
    private String richiesta;
    private String info;
    
    public Serializzatore(String richiesta, String info) {
        this.richiesta = richiesta;
        this.info = info;
    }
    public String getRichiesta() {
        return richiesta;
    }
    public void setRichiesta(String richiesta) {
        this.richiesta = richiesta;
    }
    public String getInfo() {
        return info;
    }
    public void setInfo(String info) {
        this.info = info;
    }
    public static Serializzatore fromCSV(String s){
        int indice = s.indexOf(";");
        String richiesta = s.substring(0,indice);
        String info = s.substring(indice + 1, s.length());
        return new Serializzatore(richiesta, info);
    }
}
