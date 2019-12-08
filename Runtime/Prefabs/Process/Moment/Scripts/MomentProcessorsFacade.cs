using System.Collections.Generic;
using UnityEngine;
using Zinnia.Process.Moment;

namespace VRToolkitExtras.Prefabs
{
    public class MomentProcessorsFacade : MonoBehaviour
    {
        public MomentProcessor FixedUpdate;
        public MomentProcessor Update;
        public MomentProcessor LateUpdate;
        public MomentProcessor PreCull;
        public MomentProcessor PreRender;
    
        public List<MomentsFacade> Children = new List<MomentsFacade>();

        public void AddMoments(MomentProcessor localProcessor, MomentProcess remoteProcess)
        {
            if (localProcessor == null || localProcessor.Processes == null || remoteProcess == null) return;
            localProcessor.Processes.AddUnique(remoteProcess);
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
}

