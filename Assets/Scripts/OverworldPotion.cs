using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverworldPotion : MonoBehaviour
{

    public TriggeredEvent potionEvent;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 7)
        {
            potionEvent.Trigger();
            Destroy(gameObject);
        }

    }


}
