using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class LambdaSample : MonoBehaviour{
    [SerializeField] private Text text;
    private readonly Subject<Unit> stream = new Subject<Unit>();
    public IObservable<Unit> Stream => stream;
    
    private void Start(){
        
        var teaArray = new[]{"十六","爽健美","生", "お～いお","午後の紅","太陽のマテ"};
    

        // foreach(var tea in teaArray){ text.text += tea; } // テキストに表示(確認用に使ってください)
    }
}
