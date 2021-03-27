using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public MyControllerInput rightHand;
    public MyControllerInput leftHand;

    public float movementSpeed;

    private Vector3 _moveDir;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(leftHand.touchpadState_vector2.magnitude > 0.3){
            _moveDir.x = leftHand.touchpadState_vector2.x;
            _moveDir.z = leftHand.touchpadState_vector2.y;
            _moveDir = _moveDir.normalized;
            transform.position +=  _moveDir * movementSpeed;
        }
    }
}
