using TMPro;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public TriggeredEvent deathEvent;
    public TriggeredEvent takeDamageEvent;
    public GameObject damageTextPrefab;
    public GameObject healTextPrefab;


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
        GameObject damageText = Instantiate(damageTextPrefab, transform.position, Quaternion.identity, transform);
        damageText.GetComponentInChildren<TextMeshProUGUI>().text = "-" + howMuch.ToString();
        if (currentHP <= 0 && !isDead)
        {
            currentHP = 0;
            deathEvent.Trigger();
            isDead = true;
        }
        takeDamageEvent.Trigger();

    }

    public void Heal(int howMuch)
    {
        currentHP += howMuch;
        if (currentHP > maxHP) currentHP = maxHP;
        GameObject healText = Instantiate(healTextPrefab, transform.position, Quaternion.identity, transform);
        healText.GetComponentInChildren<TextMeshProUGUI>().text = "+" + howMuch.ToString();

    }

}
