using UnityEngine;

public class Mastery : Item
{
    public override void ApplyBonus()
    {
        processor.mastery += value;
    }
}
