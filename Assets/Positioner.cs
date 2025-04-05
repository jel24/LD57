using UnityEngine;

public class Positioner : MonoBehaviour
{

    public PlayerPosition pos;

    void Awake()
    {
        transform.position = pos.playerPosition;
    }


}
