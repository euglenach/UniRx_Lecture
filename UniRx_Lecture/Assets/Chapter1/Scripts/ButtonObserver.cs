using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1.Scripts {
    public class ButtonObserver : MonoBehaviour{
        [SerializeField] Button button;
        private readonly Subject<Unit> buttonClickStream = new Subject<Unit>();
        public IObservable<Unit> OnClick => buttonClickStream;

        private void Start(){
            button.OnClickAsObservable()
                .Subscribe(_ => {
                    buttonClickStream.OnNext(Unit.Default);
                });
        }
    }
}
