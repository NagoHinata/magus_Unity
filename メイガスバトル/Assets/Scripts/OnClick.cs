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
        // �N���b�N���ꂽ���ɍs����������
        sw = !sw;
        textpanel.SetActive(sw);

    }

}