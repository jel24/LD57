using UnityEngine;
using UnityEngine.SceneManagement;

public class OverworldDoor : MonoBehaviour
{

    public string targetScene;
    bool isOpen = false;
    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;

    public void OpenDoor()
    {
        isOpen = true;
        spriteRenderer.sprite = openSprite;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 7 && isOpen)
        {
            SceneManager.LoadSceneAsync(targetScene);
        }

    }
}
