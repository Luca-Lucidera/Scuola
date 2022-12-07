/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package server;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

/**
 *
 * @author lucidera_luca
 */
public class Lista {

    private String[] listaRappClasse = {"Luca", "Mario", "PierLuigi"};
    private String[] listaRappIstituto = {"Franco", "Marco", "Baugusto"};
    private ArrayList<String> votazioniClasse;
    private ArrayList<String> votazioniIstituto;
    private ArrayList<String> ALLvotazioniClasse;
    private ArrayList<String> ALLvotazioniIstituto;
    private FileWriter w;

    public Lista() throws IOException {
        votazioniClasse = new ArrayList<String>();
        votazioniIstituto = new ArrayList<String>();
        ALLvotazioniClasse = new ArrayList<String>();
        ALLvotazioniIstituto = new ArrayList<String>();
        w = new FileWriter("risultati.txt", true);
    }

    public boolean aggiugniClasse(String p) {
        for (int i = 0; i < listaRappClasse.length; i++) {
            if (listaRappClasse[i].equals(p)) {
                votazioniClasse.add(p);
                ALLvotazioniClasse.add(p);
                return true;
            }
        }
        ALLvotazioniClasse.add(p);
        return false;

    }

    public boolean aggiugniIstituto(String p) {
        for (int i = 0; i < listaRappIstituto.length; i++) {
            if (listaRappIstituto[i].equals(p)) {
                votazioniIstituto.add(p);
                ALLvotazioniIstituto.add(p);
                return true;
            }
        }
        ALLvotazioniIstituto.add(p);
        return false;
    }

    public String checkWinner() throws IOException {
        int[] votiPosClasse = new int[listaRappClasse.length];
        int[] votiPosIst = new int[listaRappIstituto.length];
        String winner = "";
        for (int i = 0; i < votiPosClasse.length; i++) {
            votiPosClasse[i] = 0;
        }
        for (int i = 0; i < votiPosIst.length; i++) {
            votiPosIst[i] = 0;
        }
        //
        for (int i = 0; i < listaRappClasse.length; i++) {
            String nome = listaRappClasse[i];
            int c = 1;
            for (int j = 0; j < votazioniClasse.size(); j++) {
                if (nome.equals(votazioniClasse.get(j))) {
                    votiPosClasse[i] = c++;
                }
            }
        }

        int posPiuAlta = -1;
        for (int i = 0; i < votiPosClasse.length; i++) {
            if (votiPosClasse[i] > posPiuAlta) {
                posPiuAlta = votiPosClasse[i];
                winner = "Rapp di classe: " + listaRappClasse[i] + " ";
            }
        }

        for (int i = 0; i < listaRappIstituto.length; i++) {
            String nome = listaRappIstituto[i];
            int c = 1;
            for (int j = 0; j < votazioniIstituto.size(); j++) {
                if (nome.equals(votazioniIstituto.get(j))) {
                    votiPosIst[i] = c++;
                }
            }
        }

        posPiuAlta = -1;
        int x = 0;
        for (int i = 0; i < votiPosIst.length; i++) {
            if (votiPosIst[i] > posPiuAlta) {
                posPiuAlta = votiPosIst[i];
                x = i;
            }
        }
        scriviSuFile(votiPosClasse,votiPosIst);
        winner += "Rapp di istituto: " + listaRappIstituto[x];
        return winner;
    }

    private void scriviSuFile(int[]votiPosClasse, int[]votiPosIst) throws IOException {
        BufferedWriter b = new BufferedWriter(w);
        String csv = "";
        for (int i = 0; i < votiPosClasse.length; i++) {
            csv+= listaRappClasse[i] + ";"+votiPosClasse[i] + ";";
        }
        csv+="\n";
        for (int i = 0; i < votiPosIst.length; i++) {
            csv+= listaRappIstituto[i] + ";"+votiPosIst[i] + ";";
        }
        b.write(csv);
        b.flush();
        b.close();
        w.close();
    }
}
