package Array_List;

/**
 * @author Maurício Freire
 * Date 17/12/2019 at 00:47
 * Created on IntelliJ IDEA
 */
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.BufferedReader;
import java.util.ArrayList;
import java.util.Iterator;

public class Array_List {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        
        ArrayList<Pessoa> lista = new ArrayList<>();
        final int MAX = 5;
        Pessoa ps;

        for (int i = 0; i < MAX; i++) {
            System.out.print("Digite: ");
            ps = new Pessoa(br.readLine());
            lista.add(ps);
        }

        Iterator<Pessoa> it = lista.iterator();
        while (it.hasNext()) {
            ps = it.next();
            System.out.println(ps.nome);
        }
    }
}

class Pessoa {
    String nome;

    Pessoa(String nome) {
        this.nome = nome;
    }
}


