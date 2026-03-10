using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverText;
    public void displayText(int score, float time)
    {
        gameOverText.text = "Game Over!\nFinal Score: " + score + "\nTime: " + time;
    }
}
