using UnityEngine;

[CreateAssetMenu(fileName = "BattleStats", menuName = "Scriptable Objects/PlayerStats")]
public class PlayerStats : BattleStats
{
    public string nametag = "Batwise";
    
    public int maxHP;

    public override int GetHP()
    {
        return maxHP;
    }

    public override string GetNametag()
    {
        return nametag;
    }






}
