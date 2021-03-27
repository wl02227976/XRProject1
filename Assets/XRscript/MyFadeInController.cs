using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyFadeInController : MonoBehaviour
{
    public float TimeLength;
    public float StartTimeDelay;

    public bool isStart = false;
    private Image _blackImage;

    private Color black;
    private float _accTime;
    // Start is called before the first frame update
    void Start()
    {
        _blackImage = GetComponent<Image>();
        black = Color.black;
        _blackImage.color = black;
        StartCoroutine(StartDelay());   
    }

    IEnumerator StartDelay(){
        yield return new WaitForSeconds(StartTimeDelay);
        isStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isStart){
            _accTime += Time.deltaTime;
            if(_accTime <= TimeLength){
                black.a = 1-_accTime/TimeLength;
                _blackImage.color = black;
            }
        }
    }
}
