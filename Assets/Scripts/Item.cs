using UnityEngine;

public class Item : MonoBehaviour
{

    public int cooldown;
    public int value;
    public string description;
    public Sprite sprite;


    [HideInInspector] public DamageProcessor processor;



    void Start()
    {
        InvokeRepeating("Activate", cooldown, cooldown);
    }

    protected virtual void Activate()
    {

    }

    public virtual void ApplyBonus()
    {

    }


}
