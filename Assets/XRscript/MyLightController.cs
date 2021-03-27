using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLightController : MonoBehaviour
{
    public bool IsActive = false;
    public AnimationCurve lightIntensityCurve;
    public float Speed;


    float curveTime = 0f;
    Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }


    private void Update()
    {
        if(IsActive){
            curveTime += Time.deltaTime * Speed;
            if (curveTime >= 1)
            {
                curveTime -= 1;
            }
            float curveAmount = lightIntensityCurve.Evaluate(curveTime);
            light.intensity = curveAmount;
        }else{
            curveTime = 0;
            light.intensity = 0;
        }
        //transform.localScale = new Vector3(curveAmount, curveAmount, curveAmount);
    }

}
