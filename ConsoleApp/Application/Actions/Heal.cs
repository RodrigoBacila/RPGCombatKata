using Domain.Entities;
using System;
using System.Linq;

namespace Application.Actions
{
	public class Heal
	{
		public void HealCharacter(Character healingCharacter, Character targetCharacter, int healing)
		{
			if (healingCharacter.Equals(targetCharacter) || healingCharacter.Factions.Intersect(targetCharacter.Factions).Any())
			{
				if (Math.Abs(healingCharacter.PositionX - targetCharacter.PositionX) <= healingCharacter.AttackRange && Math.Abs(healingCharacter.PositionY - targetCharacter.PositionY) <= healingCharacter.AttackRange)
				{
					targetCharacter.ReceiveHealing(healing);
				}
				else
				{
					Console.WriteLine("Attack failed... Target is too far.");
				}
			}
			else
			{
				Console.WriteLine("Attack failed... Target is not an ally.");
			}
		}
	}
}
