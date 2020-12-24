/**
 * @author Maurício Freire
 * Date 24/12/2020 at 20:20
 * Created on IntelliJ IDEA
 */
 
public class Main {
    public static void main(String args[]) {
        int x = 4;
        char y = 'y';
        double p = Math.PI;
        String z = "String";
        
        GenMeth.Tipo(x);
        GenMeth.Tipo(y);
        GenMeth.Tipo(z);
        GenMeth.Tipo(p);
    }
}


class GenMeth {
    
    public static <T> void Tipo(T t) {
        
        switch(t.getClass().getName()) {
            case "java.lang.Integer":
                System.out.println(t + " é inteiro.");
                break;
            case "java.lang.Character":
                System.out.println(t + " é uma letra.");
                break;
            case "java.lang.Double":
                System.out.println(t + " é ponto flutuante.");
                break;
            default:
                System.out.println("O tipo recebido é diferente.");
        }
    }
}

