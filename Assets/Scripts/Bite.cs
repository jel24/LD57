using UnityEngine;

public class Bite : Item
{


    protected override void Activate()
    {
        enemy.TakeDamage(value);
    }


}
