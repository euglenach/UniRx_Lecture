using UniRx;
using UnityEngine;

namespace Chapter2{
    /// <summary>
    /// 時間を2倍にして表示する
    /// </summary>
    public class Show2TimesTime : MonoBehaviour{
        [SerializeField] private TimeCounter timeCounter;

        private void Start(){
            // SelectをIObservable<T>とSubscribeの間に挟む
        }
    }
}
