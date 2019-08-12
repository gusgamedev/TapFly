using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpForce = 12f;

    private bool jump = false;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") & !jump)
            jump = true;
    }

    private void FixedUpdate() {
        
        if (jump)
        {
            rb.velocity = Vector2.up * jumpForce;
            jump = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D hit) {
        //TODO col with score area

        if (hit.CompareTag("Score")) {
            GameManager.instance.score++;
        }
    }
}
