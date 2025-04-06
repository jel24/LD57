using System.Collections.Generic;
using UnityEngine;
public class BattleStats : ScriptableObject
{
    public List<GameObject> items;
    public Sprite sprite;

    public virtual int GetHP()
    {
        return 0;
    }

    public virtual string GetNametag()
    {
        return "";
    }






}
