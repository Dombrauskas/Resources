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
    
        Test ob;
        ob = new Test(3);
        ob = new Test("A");
        ob = new Test(3.7);
        ob = new Test(5.0F);
        ob = new Test(vet);
        ob = new Test(al);
    }
}

/**
 * Classes genéricas podem receber objetos de qualquer tipo.
 * Generic classes can receive objects of any type.
 */ 
class ClasseGenerica<Gen> {
    Gen g; 
    
    Test(Gen t) {
        g = t;
        Tipo();
    }
    
    void Tipo() {
        System.out.println("Tipo: " + g.getClass());
    }
}

