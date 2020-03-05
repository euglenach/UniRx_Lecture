using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Mover : MonoBehaviour{
    [SerializeField] private ArrowKeyInputObserver input;
    
    private void Start(){
        input.OnArrowInput
             .Subscribe(vec => transform.position += (Vector3)vec);
    }
}
