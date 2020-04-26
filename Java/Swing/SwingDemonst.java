package Swingz;

/**
 * @author Maurício Freire
 * Date 21/10/2019 at 23:56
 * Created on IntelliJ IDEA
 */
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class SwingDemonst implements ActionListener, FocusListener, KeyListener {
    JLabel jlb;
    JTextField jtx, jtf;
    String str = "";
    boolean f1, f2;

    SwingDemonst() {
        f1 = f2 = false;
        JFrame jfr = new JFrame("Tela Top");
        JButton btn0 = new JButton("0");
        JButton btn1 = new JButton("1");
        JButton ent = new JButton("Enter");

        jfr.setLayout(new FlowLayout());
        jfr.setSize(500, 290);
        jfr.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jtx = new JTextField(5);
        jtf = new JTextField(5);

        // Monitores de eventos
        btn0.addActionListener(this);
        btn1.addActionListener(this);
        jtx.addFocusListener(this);
        jtf.addFocusListener(this);
        jtx.addKeyListener((KeyListener) this);
        jtf.addKeyListener((KeyListener) this);
        ent.addActionListener(this);

        jlb = new JLabel("Pressione um Botão");

        jfr.add(jtx);
        jfr.add(jtf);
        jfr.add(btn0);
        jfr.add(btn1);
        jfr.add((ent));
        jfr.add(jlb);

        jfr.setVisible(true);
        // Fechar o JFrame
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getActionCommand().equals("0"))
            str += "0";
        else if (e.getActionCommand().equals("1"))
            str += "1";

        if (f1) jtx.setText(str);
        else if (f2) jtf.setText(str);
        /*
        if (jtx.isFocusOwner()) {
            jtx.setText(str);
            jtf.setText(String.valueOf(jtf.hasFocus()));
            str = "";
        }
        */

        if (e.getActionCommand().equals("Enter")) {
            jtx.setText("");
            jtf.setText("");
            jlb.setText("Salvo com sucesso");
        }
    }

    @Override
    public void focusGained(FocusEvent focusEvent) {
        /**
         * Verifica se uma (qual) caixa de texto tem o foco no dado momento
         * e, ou mantém seu texto original se houver algum ou força a caixa
         * de texto a ser vazia.
         */
        if (jtx.hasFocus()) {
            f1 = true;
            if (!str.equals(""))
                str = str;
            else str = "";
        }
        else {
            f2 = true;
            f1 = false;
            str = "";
        }
    }

    @Override
    public void focusLost(FocusEvent focusEvent) {
        //Não precisa fazer nada
        if (jtx.equals(focusEvent))
            str = jtx.getText();
        if (jtf.equals(focusEvent))
            str = jtf.getText();
    }

    @Override
    public void keyTyped(KeyEvent keyEvent) {
        /*
        if (jtx.hasFocus())
            str = jtx.getText();
        if (jtf.hasFocus())
            str = jtf.getText();

         */
    }

    @Override
    public void keyPressed(KeyEvent keyEvent) {
        /*
        if (jtx.hasFocus())
            str = jtx.getText();
        if (jtf.hasFocus())
            str = jtf.getText();

         */
    }

    @Override
    public void keyReleased(KeyEvent keyEvent) {
        /**
         * Salva os dados da caixa de texto ao soltar uma tecla, assim evita
         * que a informação seja perdida caso o usuário digite pelo teclado
         * e pela interface na mesma execução.
        */
        if (jtx.hasFocus())
            str = jtx.getText();
        if (jtf.hasFocus())
            str = jtf.getText();
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
                new SwingDemonst();
            }
        });
    }
}
