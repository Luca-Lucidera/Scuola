/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package server;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.SocketException;
import java.util.Scanner;

import javax.sound.sampled.SourceDataLine;

/**
 *
 * @author lucid
 */
public class Server {

    /**
     * @param args the command line arguments
     * @throws IOException
     * @throws InterruptedException
     */
    public static void main(String[] args) throws IOException, InterruptedException {
        ThreadServer t1 = new ThreadServer();
        t1.start();
        Scanner scanner = new Scanner(System.in);
        String s = "";
        do{
            s = scanner.nextLine();
        }while(!s.equals("exit"));
        t1.stop = true;
    }
}
