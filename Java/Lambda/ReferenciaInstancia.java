package Lambda;

import java.util.Scanner;

/**
 * @author Maurício Freire
 * Date 23/03/2020 at 18:11
 * Created on IntelliJ IDEA
 */
interface Exemplo {
    int func(int n);
}

class Math {
    private int numerador;

    Math(int numerador) {
        this.numerador = numerador;
    }

    int menorDivisor(int p) {
        for (int i = 2; i < p/i; i++)
            if (p % i == 0)
                return i;

        return 1;
    }
}

public class ReferenciaInstancia {
    public static void main(String[] args) {
        Scanner ler = new Scanner(System.in);
        int num = ler.nextInt();

        // Uma referência ao método menorDivisor é criado no objeto mt.
        // A reference to the method menorDivisor is created into mt.
        Math mt = new Math(num);
        Exemplo ex = mt::menorDivisor;

        // A referência chama o método por meio do método da interface.
        // The reference calls the method via the interface's method.
        System.out.println("Menor divisor encontrado: " + ex.func(num));
    }
}

