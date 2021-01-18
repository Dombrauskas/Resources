import java.text.SimpleDateFormat;
import java.util.Date;

public class DataFormatada_01 {
    public static void main(String[] args) {
		
        try {
		    Dias dias = new Dias();
		    System.out.println("Começou...\n");
		    dias.td.join();
		    System.out.println("...acabou.");
		} catch (InterruptedException exc) {
		    exc.printStackTrace();
		}
	}
}


class Dias implements Runnable {
    Thread td;
    
    Dias() {
        td = new Thread(this, "Titã");
        td.start();
    }
    
    public void run() {
        for (int i = 0; i < 10; i++) {
            try {
                Crono();
                Thread.sleep(1000);
            } catch (InterruptedException exc) {
                exc.printStackTrace();
            }
        }
    }
    
    void Crono() {
        Date data = new Date();
        SimpleDateFormat sdf = new SimpleDateFormat("HH:mm:ss");
        System.out.println(sdf.format(data));
        System.out.println();
    }
}

