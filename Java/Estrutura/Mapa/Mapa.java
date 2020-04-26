/**
 * @author Maurício Freire
 * Date 08/11/2019 at 13:18
 * Created on IntelliJ IDEA
 */
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;
import java.util.Map.Entry;

public class Mapa {
    public static void main(String[] args) {

        Map<String, Integer> map = new HashMap<>();
        map.put("Outubro", 10);
        map.put("Novembro", 11);
        map.put("Dezembro", 12);

        System.out.println(map);
        System.out.println(map.get("Novembro"));

        Set<Entry<String, Integer>> set = map.entrySet();
        Iterator it = set.iterator();

        while (it.hasNext()) {
            Entry<String, Integer> entry = (Entry) it.next();
            System.out.println(entry.getKey() + " "+ entry.getValue());
        }
    }
}

