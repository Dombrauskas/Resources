import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

/**
 * 
 * @author Maurício Freire
 * Entrada de dados por fluxo de bytes armazenado os dados em um buffer.
 * Data input from bytes stream storing the data typed into a buffer.
*/


public class BufferedReader {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        char control = ' ';
        do {
            System.out.print("Entre com um texto: "); 
            String text = br.readLine();
            System.out.print("Entre com um número: ");
            int num = Integer.parseInt(br.readLine());

            System.out.println(text + " " + num);
            System.out.print("Deseja repetir? S/N\t");
            control = (char) br.read();
            br.read();
        } while(control != 'N' || control != 'n');
    }
}

