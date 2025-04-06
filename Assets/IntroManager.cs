using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadWorld", 4f);
    }

    void LoadWorld()
    {
        SceneManager.LoadSceneAsync("World1");
    }
}
