using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform playerHand, playerField, enemyField;
    [SerializeField] TextMeshProUGUI playerManaPointText;
    [SerializeField] TextMeshProUGUI playerDefaultManaPointText;

    public int playerManaPoint; // �g�p����ƌ���}�i�|�C���g
    public int playerDefaultManaPoint; // ���^�[�������Ă����x�[�X�̃}�i�|�C���g

    bool isPlayerTurn = true; // �v���C���[�^�[���̃t���O
    List<int> deck = new List<int>() { 1, 2, 3, 1, 1, 2, 2, 3, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 };  // ���̃f�b�L���X�g
    //List&lt;int> deck = new List&lt;int>() { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };

void Start()
    {
        StartGame();
    }


    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void StartGame() // �����l�̐ݒ� 
    {
        /// �}�i�̏����l�ݒ� ///
        playerManaPoint = 1;
        playerDefaultManaPoint = 1;
        ShowManaPoint();

        // ������D��z��
        SetStartHand();

        // �^�[���̌���
        TurnCalc();
    }

    void ShowManaPoint() // �}�i�|�C���g��\������
    {
        playerManaPointText.text = playerManaPoint.ToString()+" / �}�i";
        //playerDefaultManaPointText.text = playerDefaultManaPoint.ToString();
    }

    public void ReduceManaPoint(int cost) // �J�[�h�g�p���A�R�X�g���}�i�|�C���g�����炷����
    {
        playerManaPoint -= cost;�@// �R�X�g�̕��A�}�i�|�C���g�����炷
        ShowManaPoint();�@�@�@�@�@// �}�i�̕\��

        //SetCanUsePanelHand();
    }
    /*
    void SetCanUsePanelHand() // ��D�̃J�[�h���擾���āA�g�p�\�ȃJ�[�h��CanUse�p�l����t����
    {
        CardController[] playerHandCardList = playerHand.GetComponentsInChildren<CardController>();
        foreach (CardController card in playerHandCardList)
        {
            if (card.model.cost <= playerManaPoint)
            {
                card.model.canUse = true;
                card.view.SetCanUsePanel(card.model.canUse); // �΂̘g����t����
            }
            else
            {
                card.model.canUse = false;
                card.view.SetCanUsePanel(card.model.canUse); // �΂̘g��������
            }
        }
    }
    */

    void CreateCard(int cardID, Transform place)
    {
        CardController card = Instantiate(cardPrefab, place);
        card.Init(cardID);
    }

    void DrawCard(Transform hand) // �J�[�h������
    {
        // �f�b�L���Ȃ��Ȃ�����Ȃ�
        if (deck.Count == 0)
        {
            return;
        }

        CardController[] playerHandCardList = playerHand.GetComponentsInChildren<CardController>();

        if (playerHandCardList.Length < 9)
        {
            // �f�b�L�̈�ԏ�̃J�[�h�����A��D�ɉ�����
            int cardID = deck[0];
            deck.RemoveAt(0);
            CreateCard(cardID, hand);
        }

        //SetCanUsePanelHand();
    }



        void SetStartHand() // ��D��3���z��
    {
        for (int i = 0; i < 3; i++)
        {
            DrawCard(playerHand);
        }
    }

    void TurnCalc() // �^�[���̐؂�ւ��Ǘ�
    {
        if (isPlayerTurn)
        {
            PlayerTurn();
        }
        else
        {
            EnemyTurn();
        }
    }

    public void ChangeTurn() // �^�[���G���h�{�^���ɂ��鏈��
    {
        isPlayerTurn = !isPlayerTurn; // �^�[�����t�ɂ���
        TurnCalc(); // �^�[���𑊎�ɉ�
    }

    void PlayerTurn()
    {
        Debug.Log("Player�̃^�[��");

        DrawCard(playerHand); // ��D���ꖇ�h���[����

        if (playerManaPoint < 20)
        playerManaPoint++; // �^�[���J�n���}�i��1���₷
        ShowManaPoint();   // �}�i�̐�����\������
    }

    void EnemyTurn()
    {
        Debug.Log("Enemy�̃^�[��");

        CardController[] enemyFieldCardList = enemyField.GetComponentsInChildren<CardController>();

        if (enemyFieldCardList.Length < 5)
        { 
        CreateCard(1, enemyField); // �J�[�h���t�B�[���h�֏o��
        }

        ChangeTurn(); // �^�[���G���h����
    }
}