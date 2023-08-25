using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    public float oppositeSpeed = 3f;
    public bool vertical;

    public float yMovementUpperLimit = 0f;
    public float yMovementLowerLimit = 0f;

    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;

        if (vertical)
        {
            position.y = position.y + speed * Time.deltaTime;
        }
        else
        {
            position.x = position.x + speed * Time.deltaTime;
        }

        rigidbody2D.MovePosition(position);

        if (vertical && position.y < yMovementLowerLimit)
        {
            speed = -speed;
        }
        else if (vertical && position.y > yMovementUpperLimit)
        {
            speed = oppositeSpeed;
        }
    }
}
