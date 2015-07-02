import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class ShooterPanel extends JPanel
{
	private int ship_yPosition = 420, enemy_yPosition = 30, enemyHeight, shipHeight, shipBullet_yPosition, shipBullet_xPosition, shipMidPosition, enemyMidPosition, shipBulletMidPosition, enemyLifeLeft = 140;
	private final int SHIP_XPOSITION = 650, ENEMY_XPOSITION = 10, PANEL_WIDTH = 800, PANEL_HEIGHT = 670, LOWER_BARRIER = 520, UPPER_BARRIER = 40;
	private JLabel shipLabel, enemyLabel, shipBulletLabel;
	private ImageIcon ship, enemy, shipBullet;
	private EnemyThread enemyThread;
	private ShipBulletThread shipBulletThread;
	private boolean shipShot = false, enemyHit = false;

	public ShooterPanel()
	{
		enemyThread = new EnemyThread(this);
		shipBulletThread = new ShipBulletThread(this);

		addKeyListener (new MovementListener());
		addMouseListener (new ShootListener());

		ship = new ImageIcon("ship.gif"); //ship is 140x140
		shipLabel = new JLabel(ship);
		add(shipLabel);
		shipLabel.setLocation(SHIP_XPOSITION, ship_yPosition);

		enemy = new ImageIcon("enemy.gif"); //enemy is 200x200
		enemyLabel = new JLabel(enemy);
		add(enemyLabel);
		enemyLabel.setLocation(ENEMY_XPOSITION, enemy_yPosition);

		shipBullet = new ImageIcon("bullet.jpg");
		shipBulletLabel = new JLabel (shipBullet);

		shipHeight = ship.getIconHeight();
		enemyHeight = enemy.getIconHeight();

		shipBullet_xPosition = SHIP_XPOSITION - shipBullet.getIconWidth();
		shipBullet_yPosition = ship_yPosition + (shipHeight / 2) - (shipBullet.getIconHeight() / 2);

		add(shipBulletLabel);

		shipMidPosition = ship_yPosition + (shipHeight / 2);
		enemyMidPosition = enemy_yPosition + (enemyHeight / 2);
		shipBulletMidPosition = shipBullet_yPosition + (shipBullet.getIconHeight() / 2);

		setPreferredSize (new Dimension(PANEL_WIDTH, PANEL_HEIGHT));
		setBackground(Color.black);
		setFocusable(true);

		enemyThread.start();
	}

	public void paintComponent(Graphics page)
	{
		super.paintComponent(page);

		page.setColor(Color.white);

		if (enemyLifeLeft == 140)
			page.fillRect(640, 10, enemyLifeLeft, 20);
		if (enemyHit)
		{
			page.fillRect(640, 10, enemyLifeLeft, 20);
			enemyHit = false;
		}

		shipLabel.setLocation(SHIP_XPOSITION, ship_yPosition);
		enemyLabel.setLocation(ENEMY_XPOSITION, enemy_yPosition);
		shipBulletLabel.setLocation(shipBullet_xPosition, shipBullet_yPosition);

		if (shipBullet_xPosition == ENEMY_XPOSITION)
		{
			enemyHit = true;
			enemyLifeLeft -= 10;
		}

		if (shipBullet_xPosition + ship.getIconWidth() <= 0)
		{
			shipShot = false;
			shipBulletThread.toggle();
			shipBullet_xPosition = SHIP_XPOSITION - shipBullet.getIconWidth();
			shipBullet_yPosition = ship_yPosition + (shipHeight / 2) - (shipBullet.getIconHeight() / 2);
			shipBulletThread = new ShipBulletThread(this);
		}
	}

	public void moveEnemy()
	{
		if (ship_yPosition > enemy_yPosition + ((enemyHeight - shipHeight) / 2))
			enemy_yPosition += 15;
		else if (ship_yPosition < enemy_yPosition + ((enemyHeight - shipHeight) / 2))
			enemy_yPosition -= 15;
		repaint();
	}

	public void shootShipBullet()
	{
		shipBullet_xPosition -= 10;
		shipShot = true;
		repaint();
	}

	public void restartShipBullet()
	{
		shipBullet_xPosition = SHIP_XPOSITION - shipBullet.getIconWidth();
		shipBullet_yPosition = ship_yPosition + (shipHeight / 2) - (shipBullet.getIconHeight() / 2);
		repaint();
	}

	public class MovementListener extends KeyAdapter
	{
		public void keyPressed(KeyEvent event)
		{
			if (event.getKeyCode() == KeyEvent.VK_UP && ship_yPosition >= UPPER_BARRIER)
			{
				ship_yPosition -= 15;
				if (!shipShot)
					shipBullet_yPosition -= 15;
				repaint();
			}
			if (event.getKeyCode() == KeyEvent.VK_DOWN && ship_yPosition <= LOWER_BARRIER)
			{
				ship_yPosition += 15;
				if (!shipShot)
					shipBullet_yPosition += 15;
				repaint();
			}
		}
	}

	public class ShootListener extends MouseAdapter
	{
		public void mouseClicked (MouseEvent event)
		{
			try
			{
				shipBulletThread.start();
			}
			catch (IllegalThreadStateException e)
			{

			}
		}
	}
}