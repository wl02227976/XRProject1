using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPickUpItem : MonoBehaviour
{
    private bool canPick = true;
    private AudioSource _aduio; 

    public GameObject hintUI;


    void Start()
    {
        _aduio = GetComponent<AudioSource>();
    }

    void OnTriggerStay(Collider other)
    {
        if(canPick && other.tag.Equals("Hand")){
            if(!hintUI.activeSelf){
                hintUI.SetActive(true);
            }
            if(other.GetComponent<MyControllerInput>().sideButtonState_bool){
                transform.parent = other.gameObject.transform;
                if(_aduio != null){
                    _aduio.Play();
                }
                hintUI.SetActive(false); 
                gameObject.SetActive(false);
                canPick = false;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag.Equals("Hand")){
            hintUI.SetActive(false);
        }
    }
}
