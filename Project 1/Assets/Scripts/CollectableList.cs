using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectableList : ScriptableObject
{
    public List<Collectable> collectables;
    public Collectable singleCollectable;

    public void AddToList(Collectable collectableObj)
    {
        collectables.Add(collectableObj);
    }

    public void RemoveFromList(Collectable collectableObj)
    {
        for (int i = 0; i < collectables.Count; i++)
        {
            if (collectables[i] == collectableObj)
            {
                collectables.Remove(collectableObj);
            }
        }
    }

    public void CheckList()
    {
        foreach (var obj in collectables)
        {
            if (obj.Contains(singleCollectable))
            {
                Debug.Log(obj);
            }
        }
    }
}
