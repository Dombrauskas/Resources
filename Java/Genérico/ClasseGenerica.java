import java.util.ArrayList;

/**
 * @author Maurício Freire
 * Date 24/12/2020 at 20:02
 * Created on IntelliJ IDEA
 */
 
public class Main {
    public static void main(String args[]) {
        int[] vet = new int[5];
        ArrayList<String> al = new ArrayList<>();        
    
        ClasseGenerica ob;
        ob = new ClasseGenerica(3);
        ob = new ClasseGenerica("A");
        ob = new ClasseGenerica(3.7);
        ob = new ClasseGenerica(5.0F);
        ob = new ClasseGenerica(vet);
        ob = new ClasseGenerica(al);
    }
}

/**
 * Classes genéricas podem receber objetos de qualquer tipo.
 * Generic classes can receive objects of any type.
 */ 
class ClasseGenerica<Gen> {
    Gen g; 
    
    ClasseGenerica(Gen t) {
        g = t;
        Tipo();
    }
    
    void Tipo() {
        System.out.println("Tipo: " + g.getClass());
    }
}

