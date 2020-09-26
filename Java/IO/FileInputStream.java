package Pgm;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

/**
 *
 * @author Maurício Freire
 * Date 26/09/2020 at 13:52
 * Created on IntelliJ IDEA
 */

public class FileInputStream {
    public static void main(String[] args) {
        int tx;

        try (FileInputStream fis = new FileInputStream("Ranking.txt")) {
            while ((tx = fis.read()) != -1) {
                System.out.print((char) tx);
            }
        } catch (FileNotFoundException e) {
            System.out.println("Arquivo não encontrado!\n" + e);
        } catch (IOException e) {
            System.out.println("Erro de I/O: " + e);
        }
    }
}
