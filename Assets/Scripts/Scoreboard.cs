using TMPro;
using UnityEngine;


class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;
    void Start()
    {
        textField = GetComponent<TMP_Text>();
        PickUp.ScoreAdded  += AddScore; 
    }
    private void AddScore(int scoreValue)
    {              
        score += scoreValue;
        textField.text = "score: " + score;
    }
}