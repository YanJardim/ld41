﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardPrefab : MonoBehaviour
{

    public Text TxtName;
    public Text TxtDescription;
    public Text TxtTurns;
    public Image ImgIcon;
    public Image ImgSelected;
    public Card Card;
    public bool IsSelected;

    // Use this for initialization
    public void SetCard(string name, string description, Sprite img, Card card)
    {
        TxtName.text = name;
        TxtDescription.text = description;
        ImgIcon.sprite = img;
        Card = card;
        TxtTurns.text = card.TurnsUnabledAfterUse.ToString();
        IsSelected = false;
    }

    public void HandleSelected()
    {
        if (IsSelected)
        {
            ImgSelected.enabled = true;
        }
        else
        {
            ImgSelected.enabled = false;

        }
    }

    void Update()
    {
        HandleSelected();
    }
}
