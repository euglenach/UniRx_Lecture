using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class ChangeTextColor : MonoBehaviour{
    [SerializeField] private Text text;
    [SerializeField] private TimeCounter timeCounter;
        

    void Start(){
        timeCounter.OnTimeCounted
                   .Subscribe(time => {
                       if(time <= 5) 
                           text.color = Color.yellow;
                   });
    }
}
