using System;
using UniRx;
using UnityEngine;

namespace Chapter2{
    /// <summary>
    /// 偶数の時だけ時間を表示する
    /// </summary>
    public class ShowEvenTime : MonoBehaviour{
        [SerializeField] private TimeCounter timeCounter;

        private void Start(){
            // WhereをIObservable<T>とSubscribeの間に挟む
        }
    }
}
