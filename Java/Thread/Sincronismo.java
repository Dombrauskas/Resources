package Pgm;

/**
 *
 * @author Maurício Freire
 * Date 01/10/2020 at 12:09
 * Created on IntelliJ IDEA
 */

public class Sincronismo {
    public static void main(String[] args) {
        int[] vet = new int[5];

        for (int i = 0; i < vet.length; i++)
            vet[i] = (int) (Math.random()*10)+1;

        SThread st1 = new SThread(vet);
        SThread st2 = new SThread(vet);

        try {
            st1.td.join();
            st2.td.join();
        } catch (InterruptedException e) {
            System.out.println(e);
        }

        for (int t : vet)
            System.out.print(t + " ");
    }
}

class SThread implements Runnable {
    Thread td;
    int[] arr;
    VetSoma vs = new VetSoma();

    SThread(int[] v) {
        td = new Thread(this);
        arr = v;
        td.start();
    }

    @Override
    public void run() {
        System.out.println("Iniciando " + Thread.currentThread().getName());
        System.out.println(Thread.currentThread().getName() + " " + vs.Soma(arr));
    }
}

class VetSoma {
    private int total;

    synchronized int Soma(int[] vetor) {
//        total = 0;
        for (int num : vetor) {
            total += num;

            System.out.println("Total em " + Thread.currentThread().getName() +
                    " " + total);
            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                System.out.println(e);
            }
        }
        return total;
    }
}

