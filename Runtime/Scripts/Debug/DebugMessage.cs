using UnityEngine;

public class DebugMessage : MonoBehaviour
{
    public string Message;

    public void DoMessage()
    {
        Debug.Log(Message);
    }
}
