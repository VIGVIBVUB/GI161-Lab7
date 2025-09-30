using UnityEngine;

public class Orc2 : Monster
{
    public override int LootReward => 30;
    public void InitializeOrc2(string name)
    {
        base.Init(name, 40, 8);
    }
    public override void Roar()
    {
        Debug.Log("Rerrrrrrr");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attack {target.Name} tang {AttackPower} damage");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
