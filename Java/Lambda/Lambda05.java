package Lambda;

import java.util.Scanner;

/**
 * @author Maurício Freire
 * Date 19/03/2020 at 22:16
 * Created on IntelliJ IDEA
 */
interface Genérico<T> {
    void func(T t);
}

public class Lambda05 {
    public static void main(String[] args) {
        Genérico<String> texto = (n) -> System.out.println(n.toUpperCase());
        Genérico<Double> raiz = (n) -> System.out.println(Math.sqrt(n));
        Genérico<Character> letra = (n) -> System.out.println("ª letra " + n);

        Scanner sc = new Scanner(System.in);
        String x = sc.nextLine();
        double y = sc.nextDouble();

        texto.func(x);
        raiz.func(y);
        int r = (int) (Math.random() * (x.length()+1));
        System.out.print(r+1);
        letra.func(x.charAt(r));
    }
}

