using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int _score = 0;

    private void Awake()
    {
        SetScore(0);
    }

    public void Add(int points)
    {
        SetScore(_score + points);
    }

    private void SetScore(int score)
    {
        _score = score;
        scoreText.text = $"Score: {_score}";
    }
}
