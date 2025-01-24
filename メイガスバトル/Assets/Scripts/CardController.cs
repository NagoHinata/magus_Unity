using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public CardView view; // �J�[�h�̌����ڂ̏���
    public CardModel model; // �J�[�h�̃f�[�^������
    public CardMovement movement;  // �ړ��Ɋւ��鑀��

    private void Awake()
    {
        view = GetComponent<CardView>();
        movement = GetComponent<CardMovement>();
    }

    public void Init(int cardID) // �J�[�h�𐶐��������ɌĂ΂��֐�
    {
        model = new CardModel(cardID); // �J�[�h�f�[�^�𐶐�
        view.Show(model); // �\��
    }

    public void DropField()
    {
        GameManager.instance.ReduceManaPoint(model.cost); // �}�i�̏���
        model.canUse = false;
        view.SetCanUsePanel(model.canUse); // �o���Ƃ�CanUsePanel������
    }
}