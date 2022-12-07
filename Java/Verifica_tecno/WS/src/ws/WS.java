/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws;

import gestoreurl.GestoreUrl;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONObject;
import open1.StaxParser;
import open1.Place;

/**
 *
 * @author lucidera_luca
 */
public class WS {

    private GestoreUrl gestore;
    private String urlBase;
    private String urlOpenStreetMap;

    public WS() {
        urlBase = "http://localhost/esercizi/ws_pozzi/";
        urlOpenStreetMap = "https://nominatim.openstreetmap.org/search?q=";
        gestore = new GestoreUrl();
    }

    public String login(String username, String password) throws IOException {
        String response = gestore.getStringResponseUrl(urlBase + "getToken.php?username=" + username + "&password=" + password);
        JSONObject json = new JSONObject(response);
        if (json.getString("status").equals("error")) {
            return "false";
        } else {
            return json.getJSONObject("value").getString("token");
        }

    }

    public boolean registrati(String username, String password) throws IOException {
        String response = gestore.getStringResponseUrl(urlBase + "register.php?username=" + username + "&password=" + password);
        JSONObject json = new JSONObject(response);
        if (json.getString("status").equals("error")) {
            return false;
        } else {
            return true;
        }
    }

    public boolean inserisciTappa(String token, String key, String stringa, int counter) throws IOException {
        String param = gestore.getParamFormatted(stringa);
        String finalString = urlOpenStreetMap + param + "&format=xml&addressdetails=1";
        String openStreetResponse = gestore.getStringResponseUrl(finalString);
        PrintWriter out = new PrintWriter("mappa.xml");
        out.write(openStreetResponse);
        out.close();
        StaxParser xmlParser = new StaxParser();
        List<Place> searchResult = xmlParser.parseXML("mappa.xml");
        if (searchResult.size() > 1) {
            String citta = searchResult.get(0).getCity();
            String response = gestore.getStringResponseUrl(urlBase + "setString.php?token=" + token + "&key=" + key + "&string=" + citta);
            JSONObject json = new JSONObject(response);
            if (json.getString("status").equals("ok")) {
                String temp = gestore.getStringResponseUrl(urlBase + "setString.php?token=" + token + "&key=counter&string=" + counter);
                return true;
            } else {
                return false;
            }
        } else {
            return false;
        }
    }

    public String listaTappe(String token, int counter) throws IOException {
        String s = "";
        int c = counter;
        String key;
        String response = "";
        boolean check = true;
        do {
            key = "citta" + c;
            response = gestore.getStringResponseUrl(urlBase + "getString.php?token=" + token + "&key=" + key);
            JSONObject json = new JSONObject(response);

            if (json.getString("status").equals("ok")) {
                s += json.getJSONObject("result").getString("string") + "\n";
            } else {
                check = false;
            }
        } while (check == true);
        return s;
    }

    public boolean rimuoviTappa(String token, String key) throws IOException {
        String response = gestore.getStringResponseUrl(urlBase + "deleteString.php?token=" + token + "&key=" + key);
        JSONObject json = new JSONObject(response);
        //troppo lunga
        return false;
    }

    public int getLastCounter(String token) throws IOException {
        //ottengo il json contentete tutte le chiavi
        String response = gestore.getStringResponseUrl(urlBase + "getKeys.php?token=" + token);
        JSONObject jsonKeys = new JSONObject(response);
        JSONArray keyArr = jsonKeys.getJSONArray("value");
        if(keyArr.length() > 0){ //controllo se ci sono elementi nel vettore di key
            for(Object key : keyArr){ //ciclo foreach
                if(key.toString().equals("counter")){
                    //ottiene il json contente il valore del counter
                    response = gestore.getStringResponseUrl(urlBase + "/getString.php?token="+ token + "&key=counter");
                    JSONObject jsonString = new JSONObject(response);
                    return jsonString.getInt("value");
                }
            }
            return 0;
        }else{
            response = gestore.getStringResponseUrl(urlBase + "/setString.php?token=" + token + "&key=counter&string=0");
            return 0;
        }
    }
}
