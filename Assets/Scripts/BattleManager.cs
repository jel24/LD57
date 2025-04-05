using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{

    public Entity enemy;
    public BattleSetupManager setupManager;
    public TriggeredEvent endBattleEvent;

    void Awake()
    {
        enemy.stats = setupManager.whichEnemy;
    }

    public void EndBattle()
    {
        endBattleEvent.Trigger();
        SceneManager.UnloadSceneAsync("BattleScene");
    }


}
