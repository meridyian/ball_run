using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 7f;
    //public Rigidbody2D rb;
    private Score score;

   
    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

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
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}