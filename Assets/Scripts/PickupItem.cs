using TMPro;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public ItemPool items;
    public TriggeredEvent itemGainedEvent;
    public PlayerStats playerStats;
    public TextMeshPro nametag;
    public TextMeshPro description;


    GameObject whichItem;




    void Start()
    {
        whichItem = items.GetRandomItem();
        nametag.text = whichItem.GetComponent<Item>().nametag;
        description.text = whichItem.GetComponent<Item>().description;

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        playerStats.AddItem(whichItem);
        itemGainedEvent.Trigger();
    }



}
