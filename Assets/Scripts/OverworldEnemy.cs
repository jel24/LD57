using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverworldEnemy : MonoBehaviour
{

    public EnemyStats whichEnemy;
    public BattleSetupManager setupManager;
    public TriggeredEvent battleStartEvent;
    public TriggeredEvent musicStartEvent;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 7)
        {
            setupManager.whichEnemy = whichEnemy;
            battleStartEvent.Trigger();
            musicStartEvent.Trigger();
            SceneManager.LoadSceneAsync("BattleScene", LoadSceneMode.Additive);
            Destroy(gameObject);
        }

    }


}
