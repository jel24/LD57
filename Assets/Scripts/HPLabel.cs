using UnityEngine;
using TMPro;

public class HPLabel : MonoBehaviour
{
    public TextMeshProUGUI label;
    public Entity entity;

    public void SetText()
    {
        label.text = entity.currentHP + "/" + entity.maxHP;
    }


}
