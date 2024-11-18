using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject cardPrefab;
    [SerializeField] Transform playerHand;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        // èD‚ğ”z‚éi©•ªj
        for (i = 0; i < 5; i++)
        {
            Instantiate(cardPrefab, playerHand);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}