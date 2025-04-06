using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class TargetSetter : MonoBehaviour
{
    public DamageProcessor processor;
    public BattleStats stats;

    void Start()
    {
        foreach (GameObject g in stats.items)
        {
            Item newItem = Instantiate(g, transform).GetComponent<Item>();
            newItem.processor = processor;
            newItem.ApplyBonus();
        }
    }

}
