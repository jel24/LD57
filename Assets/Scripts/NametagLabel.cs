using UnityEngine;
using TMPro;

public class NametagLabel : MonoBehaviour
{
    public TextMeshProUGUI label;
    public BattleStats stats;

    public void Start()
    {
        label.text = stats.GetNametag();
    }


}
