import java.awt.*;
import javax.swing.*;

public class ShooterDriver
{
	//----------------------------------------------------------
	// Creates the main program frame.
	//----------------------------------------------------------
	public static void main (String[] args)
	{
		JFrame frame = new JFrame("SHIPS LOOKS LIKE DICKS");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		frame.getContentPane().add(new ShooterPanel());
		frame.pack();
		frame.setVisible(true);
	}
}