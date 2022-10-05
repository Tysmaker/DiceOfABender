using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public int level = 1;
    public int health = 100;

    public float pSpeed;
    
    private float upDown;
    private float leftRight;

    private bool facingRight = true;

    public Rigidbody2D rb;

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

        level = data.level; 
        health = data.health;
    }
}