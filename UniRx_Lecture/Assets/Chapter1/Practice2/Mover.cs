using Practice2;
using UniRx;
using UnityEngine;

namespace Practice2{
    public class Mover : MonoBehaviour{
        [SerializeField] private ArrowKeyInputObserver input;
    
        private void Start(){
            input.OnArrowInput
                 .Subscribe(vec => transform.position += (Vector3)vec);
        }
    }
}
