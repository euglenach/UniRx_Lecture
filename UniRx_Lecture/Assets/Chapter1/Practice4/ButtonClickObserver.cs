using System;
using UniRx;
using UnityEngine;

namespace Practice4{
    public class ButtonClickObserver : MonoBehaviour{
        private readonly Subject<Unit> onClick = new Subject<Unit>();
        public IObservable<Unit> OnClick => onClick;

        public void ButtonClick(){
            onClick.OnNext(Unit.Default);
        }
    }
}
