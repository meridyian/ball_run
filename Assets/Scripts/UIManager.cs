using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private Text scoreText;

    void Start()
    {
        gameoverPanel.SetActive(false);
        scoreText.gameObject.SetActive(true);
        ToggleGameOverPanel(false);
        
    }

    
    public void ToggleGameOverPanel(bool value)
    {
        gameoverPanel.SetActive(value);
    }



}
