using System;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class TimeDisplay : MonoBehaviour{
    [SerializeField] private Text timeText;
    [SerializeField] private TimeCounter timeCounter;

    private void Start(){
        timeCounter.OnTimeCounted
                   .Subscribe(time => timeText.text = time.ToString())
                   .AddTo(this);
    }
}
