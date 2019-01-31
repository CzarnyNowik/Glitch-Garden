﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour {

    [SerializeField] float baseLives = 3;
    [SerializeField] int damage = 1;
    float lives;
    Text livesText;

    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("Difficulty setting currently is " + PlayerPrefsController.GetDifficulty());
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void LoseLives()
    {
        lives -= damage;
        UpdateDisplay();
        
        if(lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }

}
