using System;
using UniRx;
using UnityEngine;

namespace Practice5{
    public class AnyKeyInputObserver : MonoBehaviour{
        private readonly Subject<KeyCode> onAnyKey = new Subject<KeyCode>();
        public IObservable<KeyCode> OnAnyKey => onAnyKey;

        private void Update(){
            if(!Input.anyKeyDown){ return; }

            foreach(KeyCode code in Enum.GetValues(typeof(KeyCode))){
                if(Input.GetKeyDown(code)){
                    onAnyKey.OnNext(code);
                }
            }
        }
    }
}
