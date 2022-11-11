using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] float currentScore = 0f;
    [SerializeField] private Text currentScoreText;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bomb"))
        {
            currentScore++;
            currentScoreText.text = "Score :" + currentScore;

            Destroy(other.gameObject);

        }
    }
}
