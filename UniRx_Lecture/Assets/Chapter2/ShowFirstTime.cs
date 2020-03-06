using UniRx;
using UnityEngine;

namespace Chapter2{
    /// <summary>
    /// 最初の秒数だけ表示する
    /// </summary>
    public class ShowFirstTime : MonoBehaviour{
        [SerializeField] private TimeCounter timeCounter;
        private void Start(){
            // FirstをIObservable<T>とSubscribeの間に挟む
        }
    }
}
