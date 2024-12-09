using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText, attributeText, costText;
    [SerializeField] Image iconImage;

    public void Show(CardModel cardModel) // cardModel�̃f�[�^�擾�Ɣ��f
    {
        nameText.text = cardModel.name;
        attributeText.text = cardModel.name;
        costText.text = cardModel.cost.ToString();
        iconImage.sprite = cardModel.icon;
    }
}