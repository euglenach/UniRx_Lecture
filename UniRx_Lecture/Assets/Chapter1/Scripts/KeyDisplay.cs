using System;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Chapter1.Scripts {
    public class KeyDisplay : MonoBehaviour {
        [SerializeField]private KeyInputObserver input;
        [SerializeField]private Text text;
        

        private void Start(){
            input.OnKey
                .Subscribe(code => {
                    text.text = code.ToString();
                });
        }
    }
}
