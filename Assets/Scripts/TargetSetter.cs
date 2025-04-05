using UnityEngine;

public class TargetSetter : MonoBehaviour
{
    public Entity ally;
    public Entity enemy;


    void Start()
    {
        Item[] items = GetComponentsInChildren<Item>();
        foreach (Item i in items)
        {
            i.ally = ally;
            i.enemy = enemy;
        }
    }


}
