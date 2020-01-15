using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed;
    public bool isMoving;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = transform.forward * moveSpeed;
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * moveSpeed, Space.World);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = -transform.forward * moveSpeed;
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * moveSpeed, Space.World);
            isMoving = true;
        }

        if (isMoving == true)
        {
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Platform"))
        {
            this.transform.parent = collision.transform;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Platform"))
        {
            this.transform.parent = null;
        }
    }
}
