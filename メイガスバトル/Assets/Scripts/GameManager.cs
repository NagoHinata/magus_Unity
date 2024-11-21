using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform playerHand, penemyField, playerField;
    [SerializeField] Transform TurnEnd;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        // èD‚ğ”z‚éi©•ªj
        for (var i = 0; i < 5; i++)
        {
            Instantiate(cardPrefab, playerHand);
        }
        StartGame();
    }
    void StartGame()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CreateCard(int cardID, Transform place)
    {
    }
}