using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCloseTrigger : MonoBehaviour
{
    public MyDoorController DoorController;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Out NPC");
        if(other.tag.Equals("NPC")){
            Debug.Log("In NPC");
            DoorController.isOpen = false;
        }
    }
}
