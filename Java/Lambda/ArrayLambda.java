package Lambda;

/**
 * @author Maurício Freire
 * Date 12/04/2020 at 17:32
 * Created on IntelliJ IDEA
 *
 * Referência de Construtor que cria um vetor de tipo Genérico.
 * Constructor Reference which creates an array of Generic type.
 */

// Interface funcional de tipo Genérico.
// Functional interface of Generic type.
interface Arr<T> {
    // O parâmetro do método deve especificar o tamanho do vetor a ser criado.
    // The parameter of the method must specify the array size to be created.
    T[] func(int n);
}

class Alt extends Thread {

    Alt(String nome) {
        super(nome);
        start();
    }

    public void run() {
        System.out.println("Isto é uma thread! -> " + this.getName());
    }
}

public class ArrayLambda {
    public static void main(String[] args) {

        Arr<Thread> threadArrayLambda = Thread[]::new;
        Thread[] threads = threadArrayLambda.func(5);

        for (int i = 0; i < 5; i++)
            threads[i] = new Alt(Integer.toString(i));

        try {
            for (int i = 0; i < 5; i++)
            threads[i].join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        System.out.println("Finalizando Main...");
    }
}

