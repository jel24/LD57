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

    bool isDead = false;
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
        if (currentHP <= 0 && !isDead)
        {
            currentHP = 0;
            deathEvent.Trigger();
            isDead = true;
        }
        takeDamageEvent.Trigger();

    }

}
