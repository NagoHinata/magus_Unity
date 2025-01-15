using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform cardParent;
    bool canDrag = false;

    public void OnBeginDrag(PointerEventData eventData) // ドラッグを始めるときに行う処理
    {
        CardController card = GetComponent<CardController>();
        canDrag = true;

        if (card.model.canUse == false) // マナより小さいカードを使えないようにする
        {
            canDrag = false;
        }

        if (canDrag == false)
        {
            return;
        }

        cardParent = transform.parent;
        transform.SetParent(cardParent.parent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = false; // blocksRaycastsをオフにする
    }

    public void OnDrag(PointerEventData eventData) // ドラッグした時に起こす処理
    {
        if (canDrag == false)
        {
            return;
        }

        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) // カードを離したときに行う処理
    {
        if (canDrag == false)
        {
            return;
        }

        transform.SetParent(cardParent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = true; // blocksRaycastsをオンにする
    }
}
