using UnityEngine;

public class StallManager : MonoBehaviour
{

    public Entity ally;
    public Entity enemy;


    private void Start()
    {
        InvokeRepeating("StallEnder", 60f, 1f);
    }


    void StallEnder()
    {
        enemy.TakeDamage(10);
        ally.TakeDamage(10);
    }


}
