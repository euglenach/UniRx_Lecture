using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class AnyKeyInputObserver : MonoBehaviour {
    
    private readonly Subject<Unit> anyKeyStream = new Subject<Unit>();
    public IObservable<Unit> OnAnyKeyDown => anyKeyStream;

    // Update is called once per frame
    void Update(){
        if(Input.anyKeyDown){
            anyKeyStream.OnNext(Unit.Default);
        }
    }
}
