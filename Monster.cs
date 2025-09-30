using UnityEngine;

public abstract class Monster : Character
{
    public abstract int LootReward { get; }

    private bool defeated = false;
    /*
    public int LootReward
    {
        get => lootReward;
        set => lootReward = value < 0 ? 0 : value;
    }*/

    /*public MonsterType monType { get; private set; }

    private bool defeated = false;

    public void Init(MonsterType monType)
    {
        monType = monType;
        switch (monType)
        {
            case MonsterType.Orc:
                base.Init("Orc", 200, 15);
                LootReward = 100;
                break;
            case MonsterType.Orc2:
                base.Init("Orc", 10, 15);
                LootReward = 100;
                break;
            case MonsterType.Orc3:
                base.Init("Orc", 50, 15);
                LootReward = 100;
                break;
        }
    }*/

    public abstract void Roar();

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Monster Loot {LootReward}");
    }

    public override void Attack(Character target)
    {
        //base.Attack(target);
        target.TakeDamage(AttackPower);
        //Debug.Log($"{Name} M {target.Name} for {AttackPower} damage");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        //base.Attack(target);
        target.TakeDamage((AttackPower * 2) + (bonusDamage / 2));
        Debug.Log($"{Name} M {target.Name} for {AttackPower} damage");
    }

    public int DropReward()
    {
        return LootReward;
    }
}