using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BirdControl : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject mainCanvas;
    public AudioSource flapSound;
    public AudioSource pointSound;
    public AudioSource deathSound;
    private float velocity = 2;
    private Rigidbody2D rb;
    private bool isAlive;
    void Start()
    {
        isAlive = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0) && isAlive && mainCanvas.activeInHierarchy)
        {
            flapSound.Play();
            rb.velocity = Vector2.up * velocity;
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            gameManager.PauseButton();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        isAlive = false;
        deathSound.Play();
        gameManager.GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Trigger")
        {
            pointSound.Play();
        }
    }
}
