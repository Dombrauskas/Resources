package Lambda;

import java.io.IOException;
import java.io.InputStreamReader;
import java.io.Reader;

/**
 * @author Maurício Freire
 * Date 18/03/2020 at 16:04
 * Created on IntelliJ IDEA
 */

/**
 * Expressões Lambda podem lançar exceções com a cláusula throws, nestes casos
 * o método lambda pode lançar a exceção lista na interface.
 * Lambda Expressions can throw checked exceptions with throws, in these cases
 * the lambda method can throw the exception listed by the interface.
*/

interface ExcepLamb {
    boolean func(Reader rd) throws IOException;
}

public class ExcecaoLambda {
    public static void main(String[] args) throws IOException {
        int[] arr = { 80, 81, 82, 83, 84 };

        ExcepLamb lamb = (rd) -> {
            System.out.print("Digite uma letra: ");
            int val = rd.read();
            boolean b = false;
            for (int i = 0; i < arr.length - 1; i++)
                if (val == arr[i]) b = true;
            return b;
        };

        Reader re = new InputStreamReader(System.in);

        System.out.println(lamb.func(re));
    }
}

