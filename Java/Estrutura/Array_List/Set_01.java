package Array_List;

/**
 * @author Maurício Freire
 * Date 20/12/2019 at 20:01
 * Created on IntelliJ IDEA
*/
import java.util.Set;
import java.util.Collection;
import java.util.Arrays;
import java.util.HashSet;
import java.util.List;

public class Set_01 {
    private static final String[] colours = { "red", "blue", "yellow", "green", "white", "yellow" };

    Set_01 () {
//        List<String> list = new Arrays.asList(colours);
//        System.out.println("Lista: " + list);
    }

    void Imprime(Collection<String> col) {
        Set<String> set = new HashSet<>(col);
        for (String s: set)
            System.out.println(s);
    }
}

class Run {
    public static void main(String[] args) {
        Set_01 s = new Set_01();

        new Set_01();
    }
}