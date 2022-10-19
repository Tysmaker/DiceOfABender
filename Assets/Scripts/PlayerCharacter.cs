using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    public int level;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    public float pSpeed;
    private float upDown;
    private float leftRight;

    private bool facingRight = true;

    public Rigidbody2D rb;

    void Start()
    {
       currentHealth = maxHealth;
       healthBar.SetMaxHealth(maxHealth);  
      
    }

    private void Update()   
    {
        upDown = Input.GetAxisRaw("Vertical");
        leftRight = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(leftRight * pSpeed, upDown * pSpeed);

        if (leftRight > 0 && !facingRight)
        {
            Flip();
        }
        if (leftRight < 0 && facingRight)
        {
            Flip();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(level);
        Time.timeScale = 1f;
        level = data.level; 
        currentHealth = data.currentHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}