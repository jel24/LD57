using UnityEngine;

public class Vicious : Item
{
    public override void ApplyBonus()
    {
        processor.critChance += value;
    }
}
