/**
 * 
 * @author Maurício Freire
 * Argumento curinga representa um tipo desconhecido de uma classe, no exemplo
 * abaixo o curinga aceitará qualquer tipo numérico implementado por Gen.
 * The wildcard represents an unknown type of a class, in the exemple below
 * thw wildcard will accept any Number class that Gen might implement.
*/

public class Curinga {
    public static void main(String args[]) {
        int i = -9;
        long l = 9L;
        
        Gen ob1, ob2;
        ob1 = new Gen<Integer>(i);
        ob2 = new Gen<Long>(l);
        
        System.out.println(ob2.equalNumber(ob1));
    }
}


class Gen<T extends Number> {
    T num;
    
    Gen(T num) {
        this.num = num;
    }
    
    boolean equalNumber(Gen<?> gen) {
        return Math.abs(gen.num.intValue()) == Math.abs(num.intValue());
    }
}

