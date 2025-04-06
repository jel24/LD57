using UnityEngine;

public class AudioRandomizer : MonoBehaviour
{
    public AudioSource audioSource;
    
    void Start()
    {
        audioSource.pitch += (Random.Range(-.1f, .1f));
        audioSource.Play();
    }


}
