using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupInGame: Popup
{
    private void Start()
    {
        textLevel.text = "Level " + Data.CurrentLevel;
    }

    private void Update()
    {
        textPoint.text = "Point: " + GameManager.Instance.Point;
    }

    public TextMeshProUGUI textLevel;
    public TextMeshProUGUI textPoint;
    public void OnClickReplay()
    {
        GameManager.Instance.ReplayGame();
    }
}
