package Pgm;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

/**
 *
 * @author Maurício Freire
 * Date 25/09/2020 at 18:08
 * Created on IntelliJ IDEA
 */

public class FileReader {
    public static void main(String[] args) {
        String str;

        try (BufferedReader br = new BufferedReader(new java.io.FileReader("Arquivo.txt"))) {
            while ((str = br.readLine()) != null)
                System.out.println(str);
        } catch (IOException e) {
            System.out.println("Erro de I/O: " + e);
        }
    }
}
