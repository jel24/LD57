using UnityEngine;

public class Vampire : Item
{
    public override void ApplyBonus()
    {
        processor.vampiric += value;
    }
}
