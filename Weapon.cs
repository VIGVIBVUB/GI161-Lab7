using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string WeaponName { get; private set; }
    public int BonusDamage { get; private set; }
    public void Init(string weaponName, int weaponDamage)
    {
        WeaponName = weaponName;
        BonusDamage = weaponDamage;
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
