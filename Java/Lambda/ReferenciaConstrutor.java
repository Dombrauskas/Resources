package Lambda;

/**
 * @author Maurício Freire
 * Date 20/03/2020 at 22:43
 * Created on IntelliJ IDEA
 */
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

interface Lambd {
    Filme Func(String str);
}

class Filme {
    private String film;

    Filme(String str) {
        this.film = str;
    }

    String getFilm() {
        return film;
    }
}

public class ReferenciaConstrutor {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        System.out.print("Qual seu filme preferido: ");
        String s = br.readLine();

        Lambd lb = Filme::new;
        Filme ob = lb.Func(s);

        System.out.println("Filme favorito: " + ob.getFilm());
    }
}

