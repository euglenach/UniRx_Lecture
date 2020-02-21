using System;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Chapter1.Scripts {
    public class HelloDisplay_: MonoBehaviour {
        [SerializeField]private ButtonObserver buttonObserver;
        [SerializeField]private Text text;
        
        
        private void Start(){
            buttonObserver.OnClick
                .Subscribe(_ => {
                    text.text = "Hello";
                });
        }
    }
}
