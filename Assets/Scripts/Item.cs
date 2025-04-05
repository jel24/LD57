using UnityEngine;

public class Item : MonoBehaviour
{

    public int cooldown;
    public int value;

    [HideInInspector] public Entity enemy;
    [HideInInspector] public Entity ally;


    void Start()
    {
        InvokeRepeating("Activate", cooldown, cooldown);
    }

    protected virtual void Activate()
    {

    }


}
