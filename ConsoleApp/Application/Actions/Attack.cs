using Domain.Entities;
using System;
using System.Linq;

namespace Application.Actions
{
	public class Attack
	{
		public void AttackCharacter(Character attackingCharacter, Character targetCharacter, int damage)
		{
			if (!attackingCharacter.Equals(targetCharacter) && !attackingCharacter.Factions.Intersect(targetCharacter.Factions).Any())
			{
				if (Math.Abs(attackingCharacter.PositionX - targetCharacter.PositionX) <= attackingCharacter.AttackRange && Math.Abs(attackingCharacter.PositionY - targetCharacter.PositionY) <= attackingCharacter.AttackRange)
				{
					if (attackingCharacter.Level - targetCharacter.Level >= 5)
					{
						targetCharacter.ReceiveDamage((int)(damage * 1.5));
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write("Critical hit!");
						Console.ForegroundColor = ConsoleColor.Gray;
						Console.WriteLine(" Remaining target health: " + targetCharacter.Health);
					}
					else if (targetCharacter.Level - attackingCharacter.Level >= 5)
					{
						targetCharacter.ReceiveDamage((int)(damage * 0.5));
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("Attack successful!");
						Console.ForegroundColor = ConsoleColor.Gray;
						Console.WriteLine(" Remaining target health: " + targetCharacter.Health);
					}
					else
					{
						targetCharacter.ReceiveDamage(damage);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("Attack successful!");
						Console.ForegroundColor = ConsoleColor.Gray;
						Console.WriteLine(" Remaining target health: " + targetCharacter.Health);
					}

					if (!targetCharacter.Alive)
					{
						Console.WriteLine("The target was killed!");
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Attack failed...");
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.WriteLine(" Target is too far.");
				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Attack failed...");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine(" Friendly fire is disabled (thankfully, apparently...)");
			}
		}

		public void AttackProp(Character attackingCharacter, Prop targetProp, int damage)
		{
			if (Math.Abs(attackingCharacter.PositionX - targetProp.PositionX) <= attackingCharacter.AttackRange && Math.Abs(attackingCharacter.PositionY - targetProp.PositionY) <= attackingCharacter.AttackRange)
			{
				targetProp.ReceiveDamage(damage);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("Attack successful!");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine(" Remaining target health: " + targetProp.Health);

				if (targetProp.Destroyed)
				{
					Console.WriteLine("The target was destroyed!");
				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Attack failed...");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine(" Target is too far.");
			}
		}
	}
}
