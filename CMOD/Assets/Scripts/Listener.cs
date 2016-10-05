using UnityEngine;
using System.Collections;

public class Listener : MonoBehaviour
{
    public NotificationsManager Notifications = null;

    void Start() { 

        if(Notifications!=null)
            Notifications.AddListener(this, "OnKeyboardInput");
    }
    public void OnKeyboardInput(Component Sender)
    {
        Debug.Log("Keyboard Event Occurred");
    }
}