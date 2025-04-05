using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public ItemPool items;
    public TriggeredEvent itemGainedEvent;
    public PlayerStats playerStats;

    GameObject whichItem;


    void Start()
    {
        whichItem = items.GetRandomItem();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        playerStats.AddItem(whichItem);
        itemGainedEvent.Trigger();
    }



}
