using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject cardPrefab;
    [SerializeField] Transform playerHand, penemyField, playerField;
    [SerializeField] Transform TurnEnd;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        // 手札を配る（自分）
        for (i = 0; i < 5; i++)
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