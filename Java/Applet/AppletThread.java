package apt;

import java.awt.*;
import java.applet.Applet;

public class AppletThread extends Applet implements Runnable {
    String msg = "Maurício Freire";
    Thread t;
    boolean flag;

    @Override
    public void init() {
        t = null;
    }

    @Override
    public void start() {
        t = new Thread(this);
        flag = false;
        t.start();
    }

    @Override
    public void run() {
        while (true) {
            try {
                repaint();
                Thread.sleep(250);
                if (flag) break;
            } catch (InterruptedException exc) {}
        }
    }

    @Override
    public void stop() {
        flag = true;
        t = null;
    }

    @Override
    public void paint(Graphics g) {
        char ch = msg.charAt(0);
        msg = msg.substring(1, msg.length());
        msg += ch;
        g.drawString(msg, 50, 30);
    }
}

