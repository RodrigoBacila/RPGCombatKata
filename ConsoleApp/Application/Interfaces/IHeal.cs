using Domain.Entities;

namespace Application.Interfaces
{
	public interface IHeal
	{
		void HealCharacter(Character healingCharacter, Character targetCharacter, int healing);
	}
}
