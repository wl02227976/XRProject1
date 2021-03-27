using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySwitchToDrive : MonoBehaviour
{
    public GameObject WalkingDad;
    public GameObject DrivingDad;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("NPC")){
            WalkingDad.SetActive(false);
            DrivingDad.SetActive(true);
        }
    }
}
