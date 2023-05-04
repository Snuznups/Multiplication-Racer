using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGreen : MonoBehaviour
{
    private Rigidbody2D rb;
    public void Move()
    {
        
        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector2(rb.position.x + 40, rb.position.y);
    }
}
