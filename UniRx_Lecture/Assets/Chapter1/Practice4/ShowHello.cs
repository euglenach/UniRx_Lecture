using System;
using System.Drawing;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Practice4{
    public class ShowHello : MonoBehaviour{
        [SerializeField] private ButtonClickObserver buttonClickObserver;
        
        private void Start(){
            var text = GetComponent<Text>();
            
            buttonClickObserver.OnClick
                               .Subscribe(_ => {text.text = "Hello";});
        }
    }
}
