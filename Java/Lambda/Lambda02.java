package Lambda;

/**
 * @author Maurício Freire
 * Date 14/03/2020 at 23:54
 * Created on IntelliJ IDEA
 */
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

interface Func {
    int comparar(int a, int b);
}

public class Lambda02 {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        char ch;

        System.out.print("Número 1: ");
        String num1 = br.readLine();
        System.out.print("Número 2: ");
        String num2 = br.readLine();

        // Ambas expressões lambda referenciam ao mesmo método funcional.
        // Both lambda expressions refer to the same funcional method.
        Func max = (a, b) -> a > b ? a : b;

        // Lambda de Bloco: é similar a um método comum, neste tipo de lambda é
        // obrigatório o uso de return.
        // Block Lambda: it is similar to a common method, this kind of lambda
        // explicit return is mandatory.
        Func abs = (a, b) -> {
            int diff = a - b;
            if (diff < 0)
                return -diff;
            return diff;
        };

        System.out.println("Maior " + max.comparar(Integer.parseInt(num1), Integer.parseInt(num2)));
        System.out.println("Diferença absoluta: " + abs.comparar(Integer.parseInt(num1), Integer.parseInt(num2)));
    }
}

