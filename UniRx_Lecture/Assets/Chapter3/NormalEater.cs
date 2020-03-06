using UniRx;
using UnityEngine;

namespace Chapter3{
    /// <summary>
    /// 流れてきた寿司を全部食べるクラス
    /// </summary>
    public class NormalEater : MonoBehaviour{
        [SerializeField] private SushiShed sushiShed;

        private void Start(){
            sushiShed.OnShed
                     .Subscribe(sushi => {
                         var log = "I eat " + "sushi\n" +
                                         "Count: " + sushi.Count + "\n" +
                                         "Neta: " + sushi.Neta + "\n" +
                                         "Price: " + sushi.Price;
                         Debug.Log(log);
                     }).AddTo(this);
        }
    }
}
