using UnityEngine;

public class Bite : Item
{


    protected override void Activate()
    {
        processor.Damage(value);
    }


}
