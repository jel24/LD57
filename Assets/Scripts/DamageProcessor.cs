using Unity.VisualScripting;
using UnityEngine;

public class DamageProcessor : MonoBehaviour
{


    public Entity enemy;
    public Entity ally;

    [HideInInspector] public int critChance = 0;
    [HideInInspector] public int damageBonus = 0;
    [HideInInspector] public int vampiric = 0;

    public void Damage(int howMuch)
    {
        int damage = howMuch + damageBonus;
        int roll = Random.Range(0, 100);
        if (roll <= critChance)
        {
            damage *= 2;
        }
        if (vampiric > 0)
        {
            Heal(Mathf.FloorToInt(damage * (vampiric * 1f) / 100f));
        }
        enemy.TakeDamage(damage);
    }

    public void Heal(int howMuch)
    {
        if (howMuch < 1) return;
        ally.Heal(howMuch);
    }
}
