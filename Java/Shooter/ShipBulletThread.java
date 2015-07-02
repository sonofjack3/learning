public class ShipBulletThread extends Thread
{
	private ShooterPanel shooter = null;
	private boolean running = true;

	public ShipBulletThread(ShooterPanel panel)
	{
		shooter = panel;
	}

	public void run()
	{
		while (running)
		{
			try
			{
				sleep (20);
			}
			catch (InterruptedException ie)
			{
				System.exit(1);
			}

			if (running)
				shooter.shootShipBullet();
		}
	}

	public void toggle()
	{
		running = !running;
	}
}