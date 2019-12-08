using System;
using UnityEngine;
using UnityEngine.Events;

public class AwakeLifecycleEvent : MonoBehaviour
{
    
    [Serializable]
    public class UnityEvent : UnityEvent<GameObject> { }

    public UnityEvent Awaken;

    private void Awake()
    {
        Awaken?.Invoke(gameObject);
    }
}
