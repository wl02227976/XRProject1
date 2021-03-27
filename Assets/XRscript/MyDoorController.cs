using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
    public Transform LeftDoor;
    public Transform RightDoor;

    public float speed;

    public bool isOpen;
   
  
    // Update is called once per frame
    void Update()
    {
        if(isOpen){
            LeftDoor.localRotation = Quaternion.Slerp(LeftDoor.rotation, Quaternion.Euler(0,-90,0), speed);
            RightDoor.localRotation = Quaternion.Slerp(RightDoor.rotation, Quaternion.Euler(0,90,0), speed);
        }else{
            LeftDoor.localRotation = Quaternion.Slerp(LeftDoor.rotation, Quaternion.Euler(0,0,0), speed);
            RightDoor.localRotation = Quaternion.Slerp(RightDoor.rotation, Quaternion.Euler(0,0,0), speed);
        }
    }
}
