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

    public int playerManaPoint; // 使用すると減るマナポイント
    public int playerDefaultManaPoint; // 毎ターン増えていくベースのマナポイント

    bool isPlayerTurn = true; // プレイヤーターンのフラグ
    List<int> deck = new List<int>() { 1, 2, 3, 1, 1, 2, 2, 3, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 };  // 仮のデッキリスト
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

    void StartGame() // 初期値の設定 
    {
        /// マナの初期値設定 ///
        playerManaPoint = 1;
        playerDefaultManaPoint = 1;
        ShowManaPoint();

        // 初期手札を配る
        SetStartHand();

        // ターンの決定
        TurnCalc();
    }

    void ShowManaPoint() // マナポイントを表示する
    {
        playerManaPointText.text = playerManaPoint.ToString()+" / マナ";
        //playerDefaultManaPointText.text = playerDefaultManaPoint.ToString();
    }

    public void ReduceManaPoint(int cost) // カード使用時、コスト分マナポイントを減らす処理
    {
        playerManaPoint -= cost;　// コストの分、マナポイントを減らす
        ShowManaPoint();　　　　　// マナの表示

        //SetCanUsePanelHand();
    }
    /*
    void SetCanUsePanelHand() // 手札のカードを取得して、使用可能なカードにCanUseパネルを付ける
    {
        CardController[] playerHandCardList = playerHand.GetComponentsInChildren<CardController>();
        foreach (CardController card in playerHandCardList)
        {
            if (card.model.cost <= playerManaPoint)
            {
                card.model.canUse = true;
                card.view.SetCanUsePanel(card.model.canUse); // 緑の枠線を付ける
            }
            else
            {
                card.model.canUse = false;
                card.view.SetCanUsePanel(card.model.canUse); // 緑の枠線を消す
            }
        }
    }
    */

    void CreateCard(int cardID, Transform place)
    {
        CardController card = Instantiate(cardPrefab, place);
        card.Init(cardID);
    }

    void DrawCard(Transform hand) // カードを引く
    {
        // デッキがないなら引かない
        if (deck.Count == 0)
        {
            return;
        }

        CardController[] playerHandCardList = playerHand.GetComponentsInChildren<CardController>();

        if (playerHandCardList.Length < 9)
        {
            // デッキの一番上のカードを取り、手札に加える
            int cardID = deck[0];
            deck.RemoveAt(0);
            CreateCard(cardID, hand);
        }

        //SetCanUsePanelHand();
    }



        void SetStartHand() // 手札を3枚配る
    {
        for (int i = 0; i < 3; i++)
        {
            DrawCard(playerHand);
        }
    }

    void TurnCalc() // ターンの切り替え管理
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

    public void ChangeTurn() // ターンエンドボタンにつける処理
    {
        isPlayerTurn = !isPlayerTurn; // ターンを逆にする
        TurnCalc(); // ターンを相手に回す
    }

    void PlayerTurn()
    {
        Debug.Log("Playerのターン");

        DrawCard(playerHand); // 手札を一枚ドローする

        if (playerManaPoint < 20)
        playerManaPoint++; // ターン開始時マナを1増やす
        ShowManaPoint();   // マナの数字を表示する
    }

    void EnemyTurn()
    {
        Debug.Log("Enemyのターン");

        CardController[] enemyFieldCardList = enemyField.GetComponentsInChildren<CardController>();

        if (enemyFieldCardList.Length < 5)
        { 
        CreateCard(1, enemyField); // カードをフィールドへ出す
        }

        ChangeTurn(); // ターンエンドする
    }
}