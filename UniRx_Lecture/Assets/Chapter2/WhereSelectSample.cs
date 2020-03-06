using System;
using UniRx;
using UnityEngine;
using UniRx.Triggers;
using UniRx.Toolkit;

namespace Chapter2{
    /// <summary>
    /// 偶数の時だけ秒数を2倍して表示する
    /// </summary>
    public class WhereSelectSample : MonoBehaviour{
        [SerializeField] private TimeCounter timeCounter;

        private void Start(){
            // Whereでフィルタリングした後Selectで加工する
        }
    }
}
