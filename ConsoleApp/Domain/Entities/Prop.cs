namespace Domain.Entities
{
	public class Prop : Entity
	{
		public bool Destroyed { get; set; }

		public Prop(int posX, int posY)
		{
			PositionX = posX;
			PositionY = posY;
			Health = 200;
			Destroyed = false;
		}

		public Prop(int posX, int posY, int health)
		{
			PositionX = posX;
			PositionY = posY;
			Health = health;
			Destroyed = false;
		}

		public void ReceiveDamage(int damage)
		{
			if (!Destroyed)
			{
				Health -= damage;

				if (Health < 0)
				{
					Health = 0;
					Destroyed = true;
				}
			}
		}
	}
}
