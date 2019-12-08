using System;
using UnityEngine;
using UnityEngine.Events;

public class MomentsFacadeExtractor : MonoBehaviour
{
    [Serializable]
    public class UnityEvent : UnityEvent<MomentsFacade> { }

    public UnityEvent Extracted;

    public void DoExtract(GameObject target)
    {
        foreach (Transform child in target.transform)
        {
            var facade = child.GetComponent<MomentsFacade>();
            if (facade == null) continue;

            Extracted?.Invoke(facade);
            return;
        }
    }
}
