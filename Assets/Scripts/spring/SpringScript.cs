using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringScript : MonoBehaviour
{
    
    public Animator anim;
    public float jumpforce = 20;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            anim.SetBool("onSpring", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            anim.SetBool("onSpring", false);
        }

        if(collision.relativeVelocity.y <= 0f){
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if(rb != null){
                Vector2 velocity = rb.velocity;
                velocity.y = jumpforce;
                rb.velocity = velocity;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
