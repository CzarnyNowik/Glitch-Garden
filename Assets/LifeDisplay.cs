using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour {

    [SerializeField] int lives = 20;
    [SerializeField] int damage = 1;
    Text livesText;

    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
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
            FindObjectOfType<LoadScene>().LoadYouLose();
        }
    }

}
