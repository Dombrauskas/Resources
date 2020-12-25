/**
 * 
 * @author Maurício Freire
 * Tipo genérico limitado permite usar uma superclasse e suas subclasses
 * derivadas. Usa-se extends para isso.
 * Limited generic type allows to use a superclasse and its subclasses.
 * The 'extends' is used to do so.
 * 
 * Exemplo de Hebert Schildt
*/

public class TipoLimitado {
    public static void main(String args[]) {
        Num a = new Num(5.6);
        System.out.println(a.recp());
        System.out.println(a.frac());
    }
}

// T é limitado a Number e suas subclasses como Integer, Double e Float.
// String, Character ou outra classe não numérica causará erro.
// T is limited to Number and its subclasses such as Integer, Double and Float.
// String, Character or other non-numeric class will cause an error.
class Num<T extends Number> {
    T num;
    
    Num(T n) {
        num = n;
    }
    
    double recp() {
        return 1 / num.doubleValue();
    }
    
    double frac() {
        return num.doubleValue() - num.intValue();
    }
}

