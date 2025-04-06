using TMPro;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public ItemPool items;
    public TriggeredEvent itemGainedEvent;
    public PlayerStats playerStats;
    public TextMeshPro nametag;
    public TextMeshPro description;
    public SpriteRenderer sprite;

    GameObject whichItem;




    void Start()
    {
        whichItem = items.GetRandomItem();
        nametag.text = whichItem.GetComponent<Item>().nametag;
        description.text = whichItem.GetComponent<Item>().description;
        sprite.sprite = whichItem.GetComponent<Item>().sprite;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        playerStats.AddItem(whichItem);
        itemGainedEvent.Trigger();
    }



}
