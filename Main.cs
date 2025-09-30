using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //private List<Monster> monsters = new List<Monster>();

    public Hero hero;

    public List<Monster> monstersPrefabs;
    
    public Monster currenMonster;

    public List<Monster> monsters = new List<Monster>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hero.Init("VIGVIBVUB", 20, 10);
        hero.ShowStat();

        Monster orcObj = Instantiate(monstersPrefabs[0]);
        Orc orc1 = orcObj.GetComponent<Orc>();
        if (orc1 != null)
        {
            orc1.InitializeOrc("Gorash Orc");
        }
        monsters.Add(orcObj);

        Monster orc2Obj = Instantiate(monstersPrefabs[1]);
        Orc2 orc2 = orc2Obj.GetComponent<Orc2>();
        if (orc2 != null)
        {
            orc2.InitializeOrc2("Gorash Orc2");
        }
        monsters.Add(orc2Obj);

        Monster orc3Obj = Instantiate(monstersPrefabs[2]);
        Orc3 orc3 = orc3Obj.GetComponent<Orc3>();
        if (orc3 != null)
        {
            orc3.InitializeOrc3("Gorash Orc3");
        }
        monsters.Add(orc3Obj);

        //SpawnMonster(MonsterType.Orc);
        //SpawnMonster(MonsterType.Orc2);
        //SpawnMonster(MonsterType.Orc3);


        /*
        currenMonster = Instantiate(monstersPrefabs[0]);
        currenMonster.Init("Orc", 20, 10, 100);
        monsters.Add(currenMonster);
 
 
        currenMonster = Instantiate(monstersPrefabs[1]);
        currenMonster.Init("Orc2", 25, 15, 105);
        monsters.Add(currenMonster);
 
 
        currenMonster = Instantiate(monstersPrefabs[2]);
        currenMonster.Init("Orc3", 30, 20, 110);
        monsters.Add(currenMonster);*/


        foreach (var monster in monsters)
        {
            monster.ShowStat();
        }

        Debug.Log("Battle");

        currenMonster = monsters[0];

        hero.Attack(currenMonster);
        currenMonster.ShowStat();

        currenMonster.Attack(hero);
        hero.ShowStat();

        /* 
         Hero hero = new Hero("The Knight", 20, 15);
         Monster monster = new Monster("Orc", 20, 5, 10);
         Monster monster2 = new Monster("Orc2", 20, 10, 15);
         Monster monster3 = new Monster("Orc3", 20, 15, 20);
         monsters.Add(monster);
         monsters.Add(monster2);
         monsters.Add(monster3);
         monsters.Add(new Monster("Evill king", 20, 10, 30));
         monster = new Monster("Orc", 20);
         //Debug.Log($"Hero name: {hero.Name} | Hero Health: {hero.Health} | Hero gold: {hero.Gold}");
         hero.ShowStat();
         foreach (var m in monsters)
         {
             Debug.Log($"Monster Name: {m.Name} | Monster Health: {m.Health}");
             m.ShowStat();
         }
         monster2.ShowStat();
         hero.ShowStat();
         monster2.ShowStat();
         hero.ShowStat();
         monster.Attack(hero);
         hero.ShowStat();*/
    }

    /*public void SpawnMonster(MonsterType monsterType)
    {
        Monster monsterPrefab = monstersPrefabs[(int)monsterType];

        Monster monsterObj = Instantiate(monsterPrefab);

        monsterObj.Init(monsterType);
        monsters.Add(monsterObj);
    }*/

}
