using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverworldKey : MonoBehaviour
{

    public TriggeredEvent openDoorEvent;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 7)
        {
            openDoorEvent.Trigger();
            Destroy(gameObject);
        }

    }


}
