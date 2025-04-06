using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverworldChest : MonoBehaviour
{

    public TriggeredEvent battleStartEvent;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 7)
        {
            battleStartEvent.Trigger();
            SceneManager.LoadSceneAsync("Rewards", LoadSceneMode.Additive);
            Destroy(gameObject);
        }

    }


}
