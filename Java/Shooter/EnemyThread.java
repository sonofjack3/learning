import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class EnemyThread extends Thread
{
	private ShooterPanel shooter = null;

	public EnemyThread(ShooterPanel panel)
	{
		shooter = panel;
	}

	public void run()
	{
		while (true)
		{
			try
			{
				sleep (80);
			}
			catch (InterruptedException ie)
			{
				System.exit(1);
			}

			shooter.moveEnemy();
		}

	}
}
