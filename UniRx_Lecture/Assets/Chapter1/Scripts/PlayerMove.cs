using System;
using UniRx;
using UnityEngine;

namespace Chapter1.Scripts {
    public class PlayerMove : MonoBehaviour {
        [SerializeField]private MoveInputObserver moveInput;

        private void Start(){
            moveInput.OnInputArrow.Subscribe(vec => {
                transform.position += (Vector3)vec;
            });
        }
    }
}
