using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Practice3{
    public class AnyKeyInputObserver : MonoBehaviour{
        private readonly Subject<Unit> anyKeyStream = new Subject<Unit>();
        public IObservable<Unit> OnAnyKey => anyKeyStream;

        private void Update(){
            if(Input.anyKey){ anyKeyStream.OnNext(Unit.Default); }
        }
    }
}
