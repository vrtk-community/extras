using System;
using UnityEngine;
using UnityEngine.Events;
using VRTK.Prefabs.Interactions.Interactables.Grab.Action;
using Zenject;

public class GrabActionSetup : MonoBehaviour
{
    [Serializable]
    public class UnityEvent : UnityEvent<GrabInteractableAction> { }
    
    public GameObject ActionContainer;
    public UnityEvent SetupEvent;

    [Inject]
    public void Construct()
    {
        if (ActionContainer == null) return;

        var action = ActionContainer.GetComponentInChildren<GrabInteractableAction>();

        if (action == null) return;
        
        SetupEvent?.Invoke(action);
    }
}
