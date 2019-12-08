using System;
using UnityEngine;
using UnityEngine.Events;

namespace VRToolkitExtras.Data.Operation.Extraction
{
    public class ChildTransformsExtractor : MonoBehaviour
    {
        [Serializable]
        public class GameObjectUnityEvent : UnityEvent<GameObject> { }

        public GameObject Parent;
        public GameObjectUnityEvent Extracted;

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
}
