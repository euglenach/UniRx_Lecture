﻿using System;
using System.Linq;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class LambdaSample : MonoBehaviour{
    [SerializeField] private Text text; // アタッチ済み
    
    private void Start(){
        
        var teaArray = new[]{"十六","爽健美","生", "お～いお","午後の紅","太陽のマテ"};
        
        // ここにteaArrayの各要素に"茶"を追加する

        teaArray = teaArray.Select(t => t + "茶").ToArray();

        foreach(var tea in teaArray){ text.text += tea + "\n"; } // テキストに表示(確認用に使ってください)
    }
}
