using System;
using UnityEngine;
using UnityEngine.Events;

namespace VRToolkitExtras.Events.Lifecycle
{
    public class AwakeLifecycleEvent : MonoBehaviour
    {
    
        [Serializable]
        public class GameObjectUnityEvent : UnityEvent<GameObject> { }

        public GameObjectUnityEvent Awaken;

        private void Awake()
        {
            Awaken?.Invoke(gameObject);
        }
    }
}
