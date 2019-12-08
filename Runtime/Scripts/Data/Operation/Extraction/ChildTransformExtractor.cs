using System;
using UnityEngine;
using UnityEngine.Events;

namespace VRToolkitExtras.Data.Operation.Extraction
{
    public class ChildTransformExtractor : MonoBehaviour
    {
        [Serializable]
        public class GameObjectUnityEvent : UnityEvent<GameObject> { }

        public GameObject Parent;
        public GameObjectUnityEvent Extracted;

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
}
