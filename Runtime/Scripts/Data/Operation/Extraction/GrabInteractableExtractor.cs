using System;
using UnityEngine;
using UnityEngine.Events;
using VRTK.Prefabs.Interactions.Interactables.Grab.Action;

namespace VRToolkitExtras.Data.Operation.Extraction
{
    public class GrabInteractableExtractor : MonoBehaviour
    {
        [Serializable]
        public class UnityEvent : UnityEvent<GrabInteractableAction> { }

        public UnityEvent Extracted;

        public void DoExtract(GameObject container)
        {
            if (container.TryGetComponent<GrabInteractableAction>(out var action))
            {
                Extracted?.Invoke(action);
            }
        }
    }
}
