using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f;
    public bool sprint = false;

    float horizontal;
    float vertical;

    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint = true;
            speed = 9.0f;
        }
        else
        {
            sprint = false;
            speed = 6.0f;
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;

        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2D.MovePosition(position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector2(-10.4f, -4.2f);
    }
}
