using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1.Scripts {
    public class ChangeTextColor : MonoBehaviour {
        [SerializeField]private TimeCounter timeCounter;
        [SerializeField]private Text text;
        

        private void Start(){
            timeCounter.OnTimeCounted
                .Subscribe(time => {
                    if(time <= 5){
                        text.color = Color.yellow;
                    }
                });
            
            // オペレータを使った書き方
//            timeCounter.OnTimeCounted
//                .Where(time => time <= 5)
//                .Subscribe(time => {
//                    text.color = Color.yellow;
//                });
        }
    }
}
