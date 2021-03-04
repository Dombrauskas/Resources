import java.text.DateFormat;
import java.text.ParseException;
import java.util.Calendar;
import java.util.Locale;
import java.util.Date;

public class DataFormatos {
    public static void main(String args[]) { 
        Calendar c = Calendar.getInstance();
        Date data = c.getTime();
        
        Locale ru = new Locale("ru", "RUSSIA");
        Locale jp = Locale.JAPANESE;
        Locale uk = Locale.UK;
        
        System.out.println();
        DateFormat fru = DateFormat.getDateInstance(DateFormat.FULL, ru);
        System.out.println("Data e hora russa: " + fru.format(data));
        
        DateFormat fjp = DateFormat.getDateInstance(DateFormat.FULL, jp);
        System.out.println("Data e hora japonesa: " + fjp.format(data));
        
        DateFormat fuk = DateFormat.getDateInstance(DateFormat.FULL, uk);
        System.out.println("Data e hora inglesa: " + fuk.format(data));
    }
}
