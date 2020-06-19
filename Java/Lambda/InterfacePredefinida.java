package Lambda;

/**
 * @author Maurício Freire
 * Date 12/04/2020 at 20:47
 * Created on IntelliJ IDEA
 *
 * Predicate determina se um objeto de tipo T se enquadra em alguma restrição.
 * Retorna um valor boolean que indica o resultado. Seu método se chama test().
 * Predicate determine whether an object type T suits into some restriction.
 * It returns a boolean value which indicates the result. Its method is test().
 */
import java.util.function.Predicate;

public class InterfacePredefinida {
    public static void main(String[] args) {
        Predicate<Integer> predicate = (n) -> (n > 10 && n < 20);
        System.out.println(predicate.test(14));
        System.out.println(predicate.test(20));
    }
}

