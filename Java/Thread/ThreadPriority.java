package Pgm;

/**
 *
 * @author Maurício Freire
 * Date 26/09/2020 at 17:25
 * Created on IntelliJ IDEA
 */

public class ThreadPriority {
    public static void main(String[] args) {
        int x = 0;
        double tmp = System.currentTimeMillis();
        Thread_1 td = new Thread_1("Processo-1", x, tmp);
        Thread_2 th = new Thread_2("Processo-2", x, tmp);

        try {
            td.join();
            th.join();
        } catch (InterruptedException e) {
            System.out.println("Erro: " + e);
        }
    }
}

class Thread_1 extends Thread {
    int x;
    double t;

    Thread_1(String nome, int a, double t) {
        super(nome);
        this.x = a;
        this.t = t;
        start();
    }

    @Override
    public void run() {
        Thread.currentThread().setPriority(1);
        super.run();
        System.out.println(getName() + " " + getPriority());
        while (x <= 1000)
            x++;
        System.out.printf("Tempo1: %.3f\n", (System.currentTimeMillis() - t)/1000);
    }
}

class Thread_2 extends Thread {
    int x;
    double t;

    Thread_2(String nome, int a, double t) {
        super(nome);
        this.x = a;
        this.t = t;
        start();
    }

    @Override
    public void run() {
        Thread.currentThread().setPriority(10);
        super.run();
        System.out.println(getName() + " " + getPriority());
        while (x <= 1000)
            x++;
        System.out.printf("Tempo2: %.3f\n", (System.currentTimeMillis() - t) / 1000);
    }
}
