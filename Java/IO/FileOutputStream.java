package Pgm;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Scanner;

/**
 *
 * @author Maurício Freire
 * Date 26/09/2020 at 14:44
 * Created on IntelliJ IDEA
 */

public class FileOutputStream {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String txt;

        try (FileOutputStream fos = new FileOutputStream("Arquivo.txt")) {
            System.out.print("Texto: ");
            txt = scanner.nextLine();
            for (int i = 0; i < txt.length(); i++)
                fos.write(txt.charAt(i));
        } catch (FileNotFoundException e) {
            System.out.println("Arquivo não encontrado!\n" + e);
        } catch (IOException e) {
            System.out.println("Erro de I/O: " + e);
        }
    }
}
