package Lambda01;

/**
 * @author Maurício Freire
 * Date 14/03/2020 at 14:08
 * Created on IntelliJ IDEA
 */

/**
 * Função Lambda de expressão sobrescreve o método de uma interface funcional
 * com uma única linha contendo uma expressão simples.
 * Forma Lambda: () -> expressão; À esquerda tem-se a lista de parâmetros, no
 * meio o operador lambda ou operador seta e à direita a expressão.
 * Function Lambda of expression overwrites a method of an functional interface
 * with a single line which contains a single expression.
 * Lambda syntax: () -> expression; At left is the parameter list, in the middle
 * is the lambda operator or arrow operator and at right is the expression.
*/

// Interface funcional é aquela que tem apenas um método abstrato.
// Functional interface is that which has only one abstract method.
interface LambdaFunc {
    double Func();
}

public class Lambda01 {
    public static void main(String[] args) {
        // lamb é uma instância da interface e contém a expressão lambda.
        // lamb is an interface's instance containing the lambda expression.
        LambdaFunc lamb = () -> 14.08;

        System.out.println(lamb.Func());
    }
}

