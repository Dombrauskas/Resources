package Pgm;

import java.io.BufferedReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 *
 * @author Maurício Freire
 * Date 25/09/2020 at 18:08
 * Created on IntelliJ IDEA
 */

public class FileWriter {
    public static void main(String[] args) {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        try (java.io.FileWriter fw = new java.io.FileWriter("Arquivo.txt")) {
            fw.write(br.readLine());
        } catch (IOException e) {
            System.out.println("Erro de I/O: " + e);
        }
    }
}
