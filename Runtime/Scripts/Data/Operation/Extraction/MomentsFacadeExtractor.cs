using System;
using UnityEngine;
using UnityEngine.Events;

namespace VRToolkitExtras.Data.Operation.Extraction
{
    public class MomentsFacadeExtractor : MonoBehaviour
    {
        [Serializable]
        public class UnityEvent : UnityEvent<VRToolkitExtras.Prefabs.MomentsFacade> { }

        public UnityEvent Extracted;

        public void DoExtract(GameObject target)
        {
            foreach (Transform child in target.transform)
            {
                var facade = child.GetComponent<VRToolkitExtras.Prefabs.MomentsFacade>();
                if (facade == null) continue;

                Extracted?.Invoke(facade);
                return;
            }
        }
    }
}
