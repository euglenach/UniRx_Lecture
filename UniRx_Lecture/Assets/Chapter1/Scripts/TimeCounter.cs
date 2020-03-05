using System;
using System.Collections;
using UniRx;
using UnityEngine;

/// <summary>
/// カウントダウンをして、都度イベントを発行するクラス
/// </summary>
public class TimeCounter : MonoBehaviour{
    [SerializeField] private int countTime;

    private readonly Subject<int> timerSubject = new Subject<int>();
    public IObservable<int> OnTimeCounted => timerSubject;

    private void Start(){
        StartCoroutine(TimeCount());
    }

    IEnumerator TimeCount(){
        while(countTime > 0){
            countTime--;
            timerSubject.OnNext(countTime);
            yield return new WaitForSeconds(1);
        }
    }
}
