using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAIAction : MonoBehaviour
{

    private Animator _anim;
    public MySubtiteController subtiteController;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        if(subtiteController != null){
            subtiteController.EndTalkHandler += OnTurn;
        }
    }

    public void OnTurn(){
        _anim.SetTrigger("onTurn");
    }
}
