using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CardModel
{
    public int cardId;
    public string name;
    public string attribute;
    public int cost;
    public int power;
    public Sprite icon;

    public bool canUse = false;

    public CardModel(int cardID)
    {
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/Card" + cardID);

        cardId = cardEntity.cardId;
        name = cardEntity.name;
        attribute = cardEntity.name;
        cost = cardEntity.cost;
        power = cardEntity.power;
        icon = cardEntity.icon;
    }
}