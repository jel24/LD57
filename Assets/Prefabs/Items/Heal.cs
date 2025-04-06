using UnityEngine;

public class Heal : Item
{


    protected override void Activate()
    {
        processor.Heal(value);
    }


}
