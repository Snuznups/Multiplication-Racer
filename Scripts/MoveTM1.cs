using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTM1 : MonoBehaviour
{



    private Rigidbody2D rb;



    public void Move()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector2(rb.position.x + 40, 0);
    }


















    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
