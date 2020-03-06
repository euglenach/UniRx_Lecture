using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Practice5{
    public class ShowKeyCode : MonoBehaviour{
        [SerializeField] private AnyKeyInputObserver input;

        private void Start(){
            var text = GetComponent<Text>();
            
            input.OnAnyKey
                 .Subscribe(code => text.text = code.ToString());
        }
    }
}
