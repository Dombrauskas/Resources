package Pgm;

/**
 *
 * @author Maurício Freire
 * Date 26/09/2020 at 16:55
 * Created on IntelliJ IDEA
 */

public class ExemploThread {
    public static void main(String[] args) throws InterruptedException {
        System.out.println(Thread.currentThread().getName());
        Thread.sleep(2500);
        Thread.currentThread().setPriority(8);
        System.out.println(Thread.currentThread().getPriority());
        Thread.sleep(5000);
        System.out.println("Fim");
    }
}
