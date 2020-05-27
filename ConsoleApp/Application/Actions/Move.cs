using Domain.Entities;
using System;

namespace Application.Actions
{
	public class Move
	{
		public void MoveCharacter(Character character, int newPosX, int newPosY)
		{
			character.PositionX = newPosX;
			character.PositionY = newPosY;
			Console.WriteLine("Character moved to X:" + newPosX + " Y:" + newPosY);
		}
	}
}
