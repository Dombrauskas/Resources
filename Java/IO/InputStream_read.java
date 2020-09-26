package Pgm;

import java.io.IOException;

/**
 *
 * @author Maurício Freire
 * Date 26/09/2020 at 15:55
 * Created on IntelliJ IDEA
 */

public class InputStream_read {
    public static void main(String[] args) throws IOException {
        byte[] texto = new byte[10];

        System.out.print("Digite: ");
        System.in.read(texto);
        for (byte val : texto)
            System.out.print((char) val);
    }
}
