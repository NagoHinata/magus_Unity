
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// フィールドにアタッチするクラス
public class DropPlace : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) // ドロップされた時に行う処理
    {
        //CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>(); // ドラッグしてきた情報からCardMovementを取得
        CardController card = eventData.pointerDrag.GetComponent<CardController>();

        if (card != null) // もしカードがあれば、
        {
            //card.cardParent = this.transform; // カードの親要素を自分（アタッチされてるオブジェクト）にする
            card.movement.cardParent = this.transform;
            card.DropField();  // カードをフィールドに置いた時の処理を行う
        }
    }
}
