
/**
 * @author Maurício Freire
 * Date 05/05/2020 at 19:03
 * Created on IntelliJ IDEA
 * Thread cria processos que executam em paralelo. Quanto mais núcleos a CPU
 * tiver melhor será o desempenho.
 * Thread creates processes that are executed run in parallel. The more cores
 * the CPU has the better performance.
 */

class Paralelo implements Runnable {
    Thread td;
    int count = 0;
    boolean stop = false;

    Paralelo(String nome) {
        td = new Thread(this, nome);
        td.start(); // Inicia a Thread. | Starts the Thread.
    }

    public void run() {
        System.out.println("Iniciando thread - " + td.getName());

        while (!stop) {
            count++;
            System.out.println(td.getName() + ": " + count);
        }

        System.out.println("\nEncerrando a Thread - " + td.getName());
    }

}

public class ThreadRunnable {
    public static void main(String[] args) {
        Paralelo paralelo0 = new Paralelo("Processo-1");
        Paralelo paralelo1 = new Paralelo("Prpcesso-2");

        try {
            Thread.sleep(300);
            paralelo0.stop = true;
            paralelo1.stop = true;
        }
        catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}

