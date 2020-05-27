namespace Domain.Entities
{
	public class RangedFighter : Character
	{
		public RangedFighter(int posX, int posY)
		{
			PositionX = posX;
			PositionY = posY;
			AttackRange = 20;
		}
	}
}
