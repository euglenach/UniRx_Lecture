using System;
using UniRx;
using UnityEngine;

namespace Chapter1.Scripts {
    public class KeyInputObserver : MonoBehaviour {
        private readonly Subject<KeyCode> keyCodeStream = new Subject<KeyCode>();
        public IObservable<KeyCode> OnKey => keyCodeStream;

        private void Update(){
            if (Input.anyKeyDown) {
                foreach (KeyCode code in Enum.GetValues(typeof(KeyCode))) {
                    if (Input.GetKeyDown(code)) {
                        keyCodeStream.OnNext(code);
                    }
                }
            }
        }
    }
}
