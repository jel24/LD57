using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "BattleStats", menuName = "Scriptable Objects/PlayerStats")]
public class PlayerStats : BattleStats
{
    public string nametag = "Batticus";
    public int maxHP;
    public int currentHP;
    public GameObject defaultItem;

    public void NewGame()
    {
        items = new List<GameObject>();
        AddItem(defaultItem);
        SceneManager.LoadScene("Intro");
    }

    public override int GetHP()
    {
        return maxHP;
    }

    public override string GetNametag()
    {
        return nametag;
    }

    public void AddItem(GameObject item)
    {
        items.Add(item);
    }




}
