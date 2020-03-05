using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1.Scripts {
    public class HelloDisplay : MonoBehaviour {
        [SerializeField]private AnyKeyInputObserver input;
        [SerializeField]private Text text;
        

        private void Start(){
            input.OnAnyKeyDown.Subscribe(_ => {
                text.text = "Hello";
            });
        }
    }
}
