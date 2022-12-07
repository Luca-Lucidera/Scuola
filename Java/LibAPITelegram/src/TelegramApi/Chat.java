/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TelegramApi;

import org.json.JSONObject;

/**
 *
 * @author lucid
 */
public class Chat {
    private int id;
    private String first_name;
    private String last_name;
    private String username;
    private String type;

    public Chat(int id, String first_name, String last_name, String username, String type) {
        this.id = id;
        this.first_name = first_name;
        this.last_name = last_name;
        this.username = username;
        this.type = type;
    }

    Chat(Class<? extends JSONObject> aClass) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    Chat() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    public int getId() {
        return id;
    }

    public String getFirst_name() {
        return first_name;
    }

    public String getLast_name() {
        return last_name;
    }

    public String getUsername() {
        return username;
    }

    public String getType() {
        return type;
    }
    
}
