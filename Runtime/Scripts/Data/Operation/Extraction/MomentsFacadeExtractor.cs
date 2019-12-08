using System;
using UnityEngine;
using UnityEngine.Events;
using VRToolkitExtras.Prefabs;

namespace VRToolkitExtras.Data.Operation.Extraction
{
    public class MomentsFacadeExtractor : MonoBehaviour
    {
        [Serializable]
        public class MomentsFacadeUnityEvent : UnityEvent<MomentsFacade> { }

        public MomentsFacadeUnityEvent Extracted;

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
}
