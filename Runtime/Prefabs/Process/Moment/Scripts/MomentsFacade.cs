using System;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Process.Moment;

public class MomentsFacade : MonoBehaviour
{
    public MomentProcess FixedUpdate;
    public MomentProcess Update;
    public MomentProcess LateUpdate;
    public MomentProcess PreCull;
    public MomentProcess PreRender;
    
    public List<MomentsFacade> Children = new List<MomentsFacade>();

    public void AddMoments(MomentProcess localProcess, MomentProcess remoteProcess)
    {
        if (localProcess == null || remoteProcess == null) return;

        var localCompositeProcess = (CompositeProcess) localProcess.Source.Interface;
        localCompositeProcess.Processes.AddUnique(remoteProcess);
    }

    public void AddMoments(MomentsFacade moments)
    {
        AddMoments(FixedUpdate, moments.FixedUpdate);
        AddMoments(Update, moments.Update);
        AddMoments(LateUpdate, moments.LateUpdate);
        AddMoments(PreCull, moments.PreCull);
        AddMoments(PreRender, moments.PreRender);
    }

    private void Awake()
    {
        foreach (var child in Children)
        {
            AddMoments(child);
        }
    }
}
