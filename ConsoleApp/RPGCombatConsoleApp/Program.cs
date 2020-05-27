using Domain.Entities;
using RPGCombatConsoleApp.CombatSystem;
using System;

namespace RPGCombatConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			CombatManager combatManager = new CombatManager();
			Console.SetWindowSize(150, 40);
			Console.WriteLine("RPG Initialized!");
			System.Threading.Thread.Sleep(1000);

			var spearman = new MeleeFighter(0, 0)
			{
				Level = 6
			};
			Console.WriteLine("\n A level " + spearman.Level + " spearman joined the field! He is at X:" + spearman.PositionX + " Y:" + spearman.PositionY);
			System.Threading.Thread.Sleep(2000);

			var archer = new RangedFighter(6, 6);
			Console.WriteLine("A level " + archer.Level + " archer joined the field! He is at X:" + archer.PositionX + " Y:" + archer.PositionY);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n The spearman tries to attack the archer...");
			System.Threading.Thread.Sleep(2000);
			combatManager.AttackHandler.AttackCharacter(spearman, archer, 490);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n The archer notices and decides to attack the spearman...");
			System.Threading.Thread.Sleep(2000);
			combatManager.AttackHandler.AttackCharacter(archer, spearman, 260);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n The spearman is wounded in the right leg and falls on the ground, on top of his own spear!");
			System.Threading.Thread.Sleep(2000);
			combatManager.AttackHandler.AttackCharacter(spearman, spearman, 120);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n The archer laughs and fires another arrow!");
			System.Threading.Thread.Sleep(2000);
			combatManager.AttackHandler.AttackCharacter(archer, spearman, 260);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n The spearman gets up through sheer willpower and rushes towards the archer!");
			System.Threading.Thread.Sleep(2000);
			combatManager.MoveHandler.MoveCharacter(spearman, 4, 4);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n The archer is confident and shoots yet another arrow!");
			System.Threading.Thread.Sleep(2000);
			combatManager.AttackHandler.AttackCharacter(archer, spearman, 260);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n The spearman remembers he is trying to get a job and that gives him a rush of adrenaline! He attacks the archer with all his might!");
			System.Threading.Thread.Sleep(3000);
			combatManager.AttackHandler.AttackCharacter(spearman, archer, 900);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n The spearman sighs with relief for a brief moment, when...");
			System.Threading.Thread.Sleep(2000);

			var knight = new MeleeFighter(0, 0)
			{
				Level = 14
			};
			Console.WriteLine("\n A level " + knight.Level + " knight joined the field! He is at X:" + knight.PositionX + " Y:" + knight.PositionY);
			System.Threading.Thread.Sleep(2000);

			Console.WriteLine("\n ...");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("\n Uh-oh... The spearman is in trouble.");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("\n Or is he...?");
			System.Threading.Thread.Sleep(2000);
			Console.WriteLine("\n Okay. I am the spearman. Would you like to hire me so I can level up and win this fight? :)");
			Console.ReadLine();
		}
	}
}
