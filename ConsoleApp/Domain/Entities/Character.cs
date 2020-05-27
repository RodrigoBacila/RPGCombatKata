using System.Collections.Generic;

namespace Domain.Entities
{
	public class Character : Entity
	{
		public int Level { get; set; }
		public bool Alive { get; set; }
		public int AttackRange { get; set; }

		public List<Faction> Factions { get; set; }

		public Character()
		{
			Health = 1000;
			Level = 1;
			Alive = true;
			AttackRange = 2;
			Factions = new List<Faction>();
		}

		public void ReceiveDamage(int damage)
		{
			if (Alive)
			{
				Health -= damage;

				if (Health < 0)
				{
					Health = 0;
					Alive = false;
				}
			}
		}

		public void ReceiveHealing(int healing)
		{
			if (Alive)
			{
				Health += healing;

				if (Health > 1000)
				{
					Health = 1000;
				}
			}
		}

		public void JoinFaction(Faction faction)
		{
			if (!Factions.Contains(faction))
			{
				Factions.Add(faction);
			}
		}

		public void LeaveFaction(Faction faction)
		{
			if (Factions.Contains(faction))
			{
				Factions.Remove(faction);
			}
		}
	}
}
