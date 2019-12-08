using System;
using UnityEngine;
using UnityEngine.Events;

public class ChildTransformsExtractor : MonoBehaviour
{
    [Serializable]
    public class UnityEvent : UnityEvent<GameObject> { }

    public GameObject Parent;
    public UnityEvent Extracted;

    public void DoExtract(GameObject parent)
    {
        if (parent == null) return;

        if (Extracted == null) return;
        
        foreach(Transform child in parent.transform)
        {
            Extracted?.Invoke(child.gameObject);
        }
    }

    public void DoExtract()
    {
        DoExtract(Parent);
    }
}
