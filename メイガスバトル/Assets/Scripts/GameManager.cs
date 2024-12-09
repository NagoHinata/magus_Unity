
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform playerHand, playerField, enemyField;

    bool isPlayerTurn = true;
    enum Crad
    {
        Card1,
        Card2,
        Card3,
    }
    //List<int> deck = new List<int>() { 1, 2, 3, 1, 1, 2, 2, 3, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 };  //

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        CardController card = Instantiate(cardPrefab, playerHand);
        card.Init(1);
        CardController card2 = Instantiate(cardPrefab, playerHand);
        card2.Init(2);
        CardController card3 = Instantiate(cardPrefab, playerHand);
        card3.Init(2);
        CardController card4 = Instantiate(cardPrefab, playerHand);
        card4.Init(1);
    }
    /*
    void Start()
    {
        StartGame();
    }

    void StartGame() // �����l�̐ݒ� 
    {
        // ������D��z��
        SetStartHand();

        // �^�[���̌���
        TurnCalc();
    }


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

        // �f�b�L�̈�ԏ�̃J�[�h�𔲂����A��D�ɉ�����
        int cardID = deck[0];
        deck.RemoveAt(0);
        CreateCard(cardID, hand);
    }

    void SetStartHand() // ��D��3���z��
    {
        for (int i = 0; i < 3; i++)
        {
            DrawCard(playerHand);
        }
    }

    void TurnCalc() // �^�[�����Ǘ�����
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

        DrawCard(playerHand); // ��D���ꖇ������
    }

    void EnemyTurn()
    {
        Debug.Log("Enemy�̃^�[��");

        CreateCard(1, enemyField); // �J�[�h������

        ChangeTurn(); // �^�[���G���h����
    }
    */
}