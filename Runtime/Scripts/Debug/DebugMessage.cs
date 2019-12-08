using UnityEngine;

namespace VRToolkitExtras.Debug
{
    public class DebugMessage : MonoBehaviour
    {
        public string Message;

        public void DoMessage()
        {
            UnityEngine.Debug.Log(Message);
        }
    }
}
