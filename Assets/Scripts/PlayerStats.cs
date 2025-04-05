using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BattleStats", menuName = "Scriptable Objects/PlayerStats")]
public class PlayerStats : BattleStats
{
    public string nametag = "Batwise";
    public int maxHP;
    public GameObject defaultItem;

    public void NewGame()
    {
        items = new List<GameObject>();
        AddItem(defaultItem);
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
