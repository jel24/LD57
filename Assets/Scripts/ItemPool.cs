using NUnit.Framework;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemPool", menuName = "Scriptable Objects/ItemPool")]
public class ItemPool : ScriptableObject
{
    public GameObject[] itemPrefabs;

    public GameObject GetRandomItem()
    {
        return itemPrefabs[Random.Range(0, itemPrefabs.Length - 1)];
    }

}
