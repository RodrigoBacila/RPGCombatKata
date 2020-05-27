# RPGCombatKata
Skillset challenge para candidatura de emprego.

## Instructions
Complete each iteration before reading the next one.

### Iteration One
**1. All Characters, when created, have:**
- Health, starting at 1000
- Level, starting at 1
- May be Alive or Dead, starting Alive (Alive may be a true/false)

**2. Characters can Deal Damage to Characters.**
- Damage is subtracted from Health
- When damage received exceeds current Health, Health becomes 0 and the character
dies

**3. A Character can Heal a Character.**
- Dead characters cannot be healed
- Healing cannot raise health above 1000

### Iteration Two
**1. A Character cannot Deal Damage to itself.**

**2. A Character can only Heal itself.**

**3. When dealing damage:**
- If the target is 5 or more Levels above the attacker, Damage is reduced by 50%
- If the target is 5 or more levels below the attacker, Damage is increased by 50%

### Iteration Three
**1. Characters have an attack Max Range.**

**2. Melee fighters have a range of 2 meters.**

**3. Ranged fighters have a range of 20 meters.**

**4. Characters must be in range to deal damage to a target.**

### Iteration Four
**1. Characters may belong to one or more Factions.**
- Newly created Characters belong to no Faction.

**2. A Character may Join or Leave one or more Factions.**

**3. Players belonging to the same Faction are considered Allies.**

**4. Allies cannot Deal Damage to one another.**

**5. Allies can Heal one another.**

### Iteration Five
**1. Characters can damage non-character things (props).**
- Anything that has Health may be a target
- These things cannot be Healed and they do not Deal Damage
- These things do not belong to Factions; they are neutral
- When reduced to 0 Health, things are Destroyed
- As an example, you may create a Tree with 2000 Health
