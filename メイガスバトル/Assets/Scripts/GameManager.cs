using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform playerHand;
    [SerializeField] Transform TurnEnd;
    [SerializeField] Transform playerField;
    [SerializeField] Transform penemyField;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        /*
        // èD‚ğ”z‚éi©•ªj
        for (i = 0; i < 5; i++)
        {
            Instantiate(cardPrefab, playerHand);
        }
        */
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
        CardController card5 = Instantiate(cardPrefab, playerField);
        card5.Init(2);
        CardController card6 = Instantiate(cardPrefab, playerField);
        card6.Init(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CreateCard(int cardID, Transform place)
    {
        CardController card = Instantiate(cardPrefab, place);
        card.Init(cardID);
    }
}