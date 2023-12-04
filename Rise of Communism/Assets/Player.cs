using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 0f;
    public Rigidbody2D rb;
    bool onGround;
    public AudioSource manhasproblems;
    public AudioSource yeahboi;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        onGround = false;
        Debug.Log(onGround);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
            manhasproblems.Play();
            Debug.Log("SoundPlay");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            onGround = true;
            Debug.Log(onGround);
            yeahboi.Play();
            Debug.Log("SoundPlay");
        }
    }
}
