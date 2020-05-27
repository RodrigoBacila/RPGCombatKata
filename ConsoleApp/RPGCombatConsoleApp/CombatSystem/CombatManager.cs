using Application.Actions;

namespace RPGCombatConsoleApp.CombatSystem
{
	public class CombatManager
	{
		public Attack AttackHandler { get; set; }
		public Heal HealHandler { get; set; }
		public Move MoveHandler { get; set; }

		public CombatManager()
		{
			AttackHandler = new Attack();
			HealHandler = new Heal();
			MoveHandler = new Move();
		}
	}
}
