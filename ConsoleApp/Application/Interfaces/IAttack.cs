using Domain.Entities;

namespace Application.Interfaces
{
	public interface IAttack
	{
		void AttackCharacter(Character attackingCharacter, Character targetCharacter, int damage);
		void AttackProp(Character attackingCharacter, Prop targetProp, int damage);
	}
}
