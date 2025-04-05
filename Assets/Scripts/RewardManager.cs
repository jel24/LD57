using UnityEngine;
using UnityEngine.SceneManagement;

public class RewardManager : MonoBehaviour
{
    
    public void CloseItems()
    {
        SceneManager.UnloadSceneAsync("Rewards");
    }


}
