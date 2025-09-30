using UnityEngine;

public class Hero : Character
{
    private int gold;

    /*public int Gold
    {
        get { return gold; }
        set
        {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else { gold = value; }
        }
    }*/

    public int Gold { get; private set; }
    private int maxGold = 999;


    public void Init(string newName, int newHp, int newAttackPower)
    {
        base.Init(newName, newHp, newAttackPower);
        Gold = 0;
    }

    public void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Hero Gold : {Gold}");
    }

    public override void Attack(Character target)
    {
        //base.Attack(target);
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} H {target.Name} for {AttackPower} damage");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        //base.Attack(target);
        target.TakeDamage(AttackPower + bonusDamage);
        Debug.Log($"{Name} H {target.Name} for {AttackPower} damage {bonusDamage} Bonus");
    }
    /*
    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }*/

    public void Heal(int healAmount)
    {
        Health = Mathf.Clamp(Health + healAmount, 0, maxHealth);
        Debug.Log($"{Name} heal {healAmount} Hp ; Curren Health {Health}");
    }

    /*public void EarnGold(int amount)
    {
        if (amount > 0)
        {
            Gold += amount;
        }
    }*/

    public void EarnGold(int amount)
    {
        if (amount > 0)
        {
            Gold = Mathf.Clamp(Gold + amount, 0, maxGold);
            Debug.Log($"{Name} earned {amount} golds");
        }
    }

}