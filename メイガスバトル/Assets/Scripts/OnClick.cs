using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject textpanel;
    bool sw = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        // クリックされた時に行いたい処理
        sw = !sw;
        textpanel.SetActive(sw);

    }

}