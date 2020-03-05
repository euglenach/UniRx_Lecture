using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace Practice3{
    public class ShowHello : MonoBehaviour{
        [SerializeField] private AnyKeyInputObserver input;
        
        private Text text;

        private void Start(){
            text = GetComponent<Text>();

            input.OnAnyKey.Subscribe(_ => text.text = "Hello");
        }
    }
}
