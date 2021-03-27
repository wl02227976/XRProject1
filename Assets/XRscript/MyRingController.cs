using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRingController : MonoBehaviour
{
    public bool IsActive = false;
    AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void SetAudioActive(bool value){
        if(value){
            _audio.Play();
        }else{
            _audio.Stop();
        }
    }
}
