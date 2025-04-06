using UnityEngine;

public class Claws : Item
{
    public override void ApplyBonus()
    {
        processor.damageBonus += value;
    }
}
