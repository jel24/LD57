using UnityEngine;
using UnityEngine.SceneManagement;

public class OverworldEnemy : MonoBehaviour
{

    public EnemyStats whichEnemy;
    public BattleSetupManager setupManager;
    public TriggeredEvent battleStartEvent;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        setupManager.whichEnemy = whichEnemy;
        battleStartEvent.Trigger();
        SceneManager.LoadSceneAsync("BattleScene", LoadSceneMode.Additive);
        Destroy(gameObject);
    }



}
