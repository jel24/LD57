using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Vector2 direction;
    public Rigidbody2D rb;
    public SpriteRenderer sprite;

    float whichWay = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = direction;
    }

    public void StopMoving()
    {
        rb.linearVelocity = Vector2.zero;
    }

    public void StartMoving()
    {
        rb.linearVelocity = direction * whichWay;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        whichWay *= -1f;
        sprite.flipX = !sprite.flipX;
        rb.linearVelocity = direction * whichWay;
    }




}
