using System;
using UniRx;
using UnityEngine;

namespace Practice2{
    public class ArrowKeyInputObserver : MonoBehaviour{
        private readonly Subject<Vector2> arrowInputStream = new Subject<Vector2>();
        public IObservable<Vector2> OnArrowInput => arrowInputStream;

        private void Update(){
            var y = Input.GetAxisRaw("Vertical");
            var x = Input.GetAxisRaw("Horizontal");

            if(x != 0){
                arrowInputStream.OnNext(new Vector2(x,0));
            }

            if(y != 0){
                arrowInputStream.OnNext(new Vector2(0,y));
            }
        }
    }
}
