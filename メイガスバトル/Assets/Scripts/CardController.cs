using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public CardView view; // カードの見た目の処理
    public CardModel model; // カードのデータを処理
    public CardMovement movement;  // 移動に関する操作

    private void Awake()
    {
        view = GetComponent<CardView>();
        movement = GetComponent<CardMovement>();
    }

    public void Init(int cardID) // カードを生成した時に呼ばれる関数
    {
        model = new CardModel(cardID); // カードデータを生成
        view.Show(model); // 表示
    }

    public void DropField()
    {
        GameManager.instance.ReduceManaPoint(model.cost); // マナの処理
        model.canUse = false;
        //view.SetCanUsePanel(model.canUse); // 出すときにCanUsePanelを消す
    }
}