using Domain.Entities;

namespace Application.Interfaces
{
	public interface IMove
	{
		void MoveCharacter(Character character, int newPosX, int newPosY);
	}
}
