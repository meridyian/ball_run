using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 5f;
    //public Rigidbody2D rb;
    private Score score;
    [SerializeField] private bool isDead;
    [SerializeField] private UIManager uiManager;
    [SerializeField] BombSpawner bombSpawner;

    public void Start()
    {
        isDead = false;
    }


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(x, 0, 0);

        transform.Translate(movement * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bomb"))
        {
            Die();
            
            
        }
    }

    private void Die()
    {
        uiManager.ToggleGameOverPanel(true);
        isDead = true;
        gameObject.SetActive(false);
        bombSpawner.isGameOver = true;
    }




}