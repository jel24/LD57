using System.Collections.Generic;
using UnityEngine;
public class BattleStats : ScriptableObject
{
    public List<GameObject> items;


    public virtual int GetHP()
    {
        return 0;
    }

    public virtual string GetNametag()
    {
        return "";
    }






}
