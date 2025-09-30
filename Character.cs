using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public Weapon EquippedWeapon { get; private set; }

    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknow Hero"; }
            else { name = value; }
        }
    }
    public int Health { get; protected set; }
    protected int maxHealth = 200;
    /*private int Health;

    public int health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }*/
    public int AttackPower { get; set; }
    public void Init(string newName, int newHp, int newAttackPower)
    {
        Name = newName;
        Health = newHp;
        AttackPower = newAttackPower;
    }
    public virtual void ShowStat()
    {
        Debug.Log($"charater name: {Name} | charater Health: {Health} | charater Attack Power: {AttackPower}");
    }
    public void TakeDamage(int damageValue)
    {
        //Health -= damageValue;
        Health = Mathf.Clamp(Health -= damageValue, 0, maxHealth);
        Debug.Log($"{Name} takes {damageValue} total {Health}");
        /*
        if (Health >= 0) Health = 0;
        else if (Health > maxHealth) Health = maxHealth;*/
    }
    public abstract void Attack(Character target);
    public abstract void Attack(Character target, int bonusDamage);

    public virtual void Attack(Character target, Weapon weapon)
    {
        if (weapon != null)
        {
            int damage = AttackPower + weapon.BonusDamage;
            target.TakeDamage(damage);
            Debug.Log($"(Name) uses a {weapon. WeaponName} with Bonus {weapon.BonusDamage}" +
                 $"-> deals total(damage) damage! to(target.Name).");
        }
    }
    //public abstract void OnDefeated();

    /*
    public virtual void Attack(Character target)
    {
        //Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }*/
    public bool IsAlive() { return Health > 0; }

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
    }
}