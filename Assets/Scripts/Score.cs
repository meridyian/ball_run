using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private float currentScore = 0f;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bomb"))
        {
            currentScore++;
            Debug.Log(currentScore);
            Destroy(other.gameObject);

        }
    }
}
