using TMPro;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public TriggeredEvent deathEvent;
    public TriggeredEvent takeDamageEvent;
    public GameObject textPrefab;


    [HideInInspector] public BattleStats stats;
    [HideInInspector] public int currentHP;
    [HideInInspector] public int maxHP;

    void Start()
    {
        maxHP = stats.GetHP();
        currentHP = maxHP;
        takeDamageEvent.Trigger();

    }

    public void TakeDamage(int howMuch)
    {
        currentHP -= howMuch;
        GameObject damageText = Instantiate(textPrefab, transform.position, Quaternion.identity, transform);
        damageText.GetComponentInChildren<TextMeshProUGUI>().text = "-" + howMuch.ToString();
        if (currentHP <= 0)
        {
            currentHP = 0;
            deathEvent.Trigger();
        }
        takeDamageEvent.Trigger();

    }

}
