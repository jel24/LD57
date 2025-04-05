using UnityEngine;

[CreateAssetMenu(fileName = "BattleStats", menuName = "Scriptable Objects/EnemyStats")]
public class EnemyStats : BattleStats
{
    public string nametag;
    
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
