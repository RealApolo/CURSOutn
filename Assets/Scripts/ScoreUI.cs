using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textScore;
    public static int score = 0;

    private void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score++;
    }
    
    void Update()
    {
        textScore.text = score.ToString();
    }
}
