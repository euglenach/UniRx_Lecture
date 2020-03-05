using System;
using UniRx;
using UnityEngine;

namespace Chapter1.Scripts {
    public class MoveInputObserver : MonoBehaviour {
        private readonly Subject<Vector2> moveStream = new Subject<Vector2>();
        public IObservable<Vector2> OnInputArrow => moveStream;

        private void Start(){
            
        }

        private void Update(){
            var y = Input.GetAxisRaw("Vertical");
            var x = Input.GetAxisRaw("Horizontal");
            
            if(y != 0){
                moveStream.OnNext(new Vector2(0,y));
            }

            if(x != 0){
                moveStream.OnNext(new Vector2(x,0));
            }
        }
    }
}
