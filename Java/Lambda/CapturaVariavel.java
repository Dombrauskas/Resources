package Lambda;

/**
 * @author Maurício Freire
 * Date 18/03/2020 at 15:16
 * Created on IntelliJ IDEA
 */

/**
 * Expressões Lambda que capturam variáveis: a captura de uma variável ocorre
 * quando a expressão lambda faz uso de uma variável local do escopo em que se
 * encontra, esta variável deve ser efetivamente final, ou seja, seu valor não
 * pode ser alterado após ser atribuído, entretanto, não há necessidade de ser
 * explicitamente declarada como tal.
 * Lambda Expressions that capture variables: the capture of a variable occurs
 * when a lambda expression uses a variable from the local scope (where lambda
 * is in), this variable must be effectively final, i.e., its value cannot be
 * changed after assigned. However, it does not need to be explicitly declared
 * as a final variable.
 */

interface EL {
    int fun(int num);
}

public class CapturaVariavel {
    public static void main(String[] args) {
        // Variável local que será "capturada" por lambda. Seu valor mudará.
        // Local variable that'll be 'captured' by lambda. Its value won't change.
        int x = 14;

        EL lambda = (n) -> {
            // Mesmo usando n para uma operação isso não altera o seu valor.
            // Even using n in an operation it does not change its value.
            int y = x * x;
            // Causará erro fora do comentário.
            // It will cause an error out comment.
            // x++;

            // Isto também é errado.
            // This is also an error.
            // x = 7;
            return y;
        };

        System.out.println(lambda.fun(x));
    }
}

