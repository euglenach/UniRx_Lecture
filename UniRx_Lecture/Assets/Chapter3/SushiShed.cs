using System;
using UniRx;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Chapter3{
    /// <summary>
    /// 1秒ごとにランダムな寿司を流すクラス
    /// </summary>
    public class SushiShed : MonoBehaviour{
        private readonly Subject<Sushi> sushiStream = new Subject<Sushi>();
        public IObservable<Sushi> OnShed => sushiStream;

        private void Start(){
            var neta = new[]{"赤身", "中とろ", "大トロ", "ぶり", "サーモン"};

            Observable.Interval(TimeSpan.FromSeconds(1))
                      .Subscribe(_ => {
                          var count = Random.Range(1, 3); // 1貫か2貫
                          var i = Random.Range(0, neta.Length);
                          var price = Random.Range(100, 501);
                          sushiStream.OnNext(new Sushi(count, neta[i], price));
                      })
                      .AddTo(this);
        }
    }
}
