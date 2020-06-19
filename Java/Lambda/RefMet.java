package Lambda;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * @author Maurício Freire
 * Date 19/03/2020 at 16:52
 * Created on IntelliJ IDEA
 */

/**
 * Referência de Método é uma maneira de referenciar um método sem executá-lo.
 * Requer uma interface funcional compatível.
 * Method Reference is a context of referring to a method without running it.
 * It requires a compatible functional interface.
 */
interface Refer {
    boolean exemplo(int num);
}

class Implementar {

    static boolean anoBissexto(int ano) {
        return (ano % 4) == 0 && (ano % 100) != 0;
    }

    static boolean numeroPrimo(int num) {
        if (num % 2 == 0) return false;

        for (int i = 2; i < num/i; i++)
            if (num % i == 0) return false;

        return true;
    }
}

class MetodoReferencia {

    // Método com uma interface funcional como parâmetro.
    // Method with a functional interface as a parameter.
    static boolean auxiliar(Refer rf, int i) {
        return rf.exemplo(i);
    }
}

public class RefMet {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String ano, num;

        System.out.print("Informe um ano: ");
        ano = br.readLine();
        System.out.print("Digite um número: ");
        num = br.readLine();

        if (MetodoReferencia.auxiliar(Implementar::anoBissexto, Integer.parseInt(ano)))
            System.out.println(ano + " é um ano bissexto");
        else System.out.println(ano + " não é um ano bissexto");

        if (MetodoReferencia.auxiliar(Implementar::numeroPrimo, Integer.parseInt(num)))
            System.out.println(num + " é um número primo");
        else System.out.println(num + " não é um número primo");
    }
}

