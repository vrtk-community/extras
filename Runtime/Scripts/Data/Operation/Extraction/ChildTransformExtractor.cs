using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChildTransformExtractor : MonoBehaviour
{
    [Serializable]
    public class UnityEvent : UnityEvent<GameObject> { }

    public GameObject Parent;
    public UnityEvent Extracted;

    public void DoExtract(GameObject parent)
    {
        if (parent == null) return;

        if (Extracted == null) return;

        foreach (Transform child in parent.transform)
        {
            if (!child.gameObject.activeInHierarchy) continue;
            Extracted.Invoke(child.gameObject);
            return;
        }
    }

    public void DoExtract()
    {
        DoExtract(Parent);
    }
}
