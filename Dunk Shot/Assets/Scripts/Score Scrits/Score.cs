using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _best_scoreText;
    private int _score;
    private int best_score;
    private bool _additional;

    [SerializeField] private Exit_from_arena _Exit_from_arena;

    void Start()
    {
     best_score = PlayerPrefs.GetInt("Best score");
     _best_scoreText.text = best_score.ToString();
    }

    public void score()
    {
     _score++;
     _scoreText.text = _score.ToString();

     if(_score > best_score)
       {
         best_score = _score;
         _best_scoreText.text = best_score.ToString();
         PlayerPrefs.SetInt("Best score", best_score);
       }

       _Exit_from_arena.Check(_score);
    }

    public void Additional()
    {
      _additional = false;
    }
}
