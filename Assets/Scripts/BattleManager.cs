using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{

    public Entity enemy;
    public TargetSetter enemyTargetSetter;
    public TextMeshProUGUI nametagLabel;
    public BattleSetupManager setupManager;
    public TriggeredEvent endBattleEvent;

    void Awake()
    {
        enemy.stats = setupManager.whichEnemy;
        nametagLabel.text = setupManager.whichEnemy.nametag;
        enemyTargetSetter.stats = setupManager.whichEnemy;
    }

    public void EndBattle()
    {
        //endBattleEvent.Trigger();
        SceneManager.LoadSceneAsync("Rewards", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("BattleScene");
    }

    public void GameOver()
    {
        SceneManager.LoadSceneAsync("GameOver");
    }
}
