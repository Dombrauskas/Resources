import java.applet.Applet;
import java.awt.*;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;

/**
 *
 * @author Maurício Freire
 * Date 26/04/2020 at 17:55
 * Desmonstra o Tratamento de evento em applets.
 * Demonstrates the Event treatment in applets.
 *
 * Exemplo de Herbert Schildt
 */


//<applet code="TratamentoEvento" width=200 height=100></applet>

public class TratamentoEvento extends Applet
        implements MouseListener, MouseMotionListener {
    String txt = "";
    int x = 0, y = 0;

    @Override
    public void init() {
        addMouseListener(this);
        addMouseMotionListener(this);
    }

    @Override
    public void mouseClicked(MouseEvent mouseEvent) {
        x = 0;
        y = 10;
        txt = "Mouse clicado";
        repaint();
    }

    @Override
    public void mouseEntered(MouseEvent mouseEvent) {
        x = 0;
        y = 10;
        txt = "Mouse na janela";
        repaint();
    }

    @Override
    public void mouseExited(MouseEvent mouseEvent) {
        x = 0;
        y = 10;
        txt = "Mouse fora da janela";
        repaint();
    }

    @Override
    public void mousePressed(MouseEvent mouseEvent) {
        x = mouseEvent.getX();
        y = mouseEvent.getY();
        txt = "Apertou";
        repaint();
    }

    @Override
    public void mouseReleased(MouseEvent mouseEvent) {
        x = mouseEvent.getX();
        y = mouseEvent.getY();
        txt = "Soltou";
        repaint();
    }

    @Override
    public void mouseDragged(MouseEvent mouseEvent) {
        x = mouseEvent.getX();
        y = mouseEvent.getY();
        txt = "*";
        showStatus("Arrastando o mouse em " + x + " " + y);
    }

    @Override
    public void mouseMoved(MouseEvent mouseEvent) {
        x = mouseEvent.getX();
        y = mouseEvent.getY();
        showStatus("Mouse movido em " + x + " " + y);
    }

    @Override
    public void paint(Graphics g) {
        g.drawString(txt, x, y);
    }
}

