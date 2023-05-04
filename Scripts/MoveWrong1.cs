using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWrong1 : MonoBehaviour
{

    private Rigidbody2D rb;
    private int pos;
    Green1Pass green1Pass;

    public void Move(int a)
    {
        pos = a;

        rb = GetComponent<Rigidbody2D>();
        green1Pass = GameObject.FindGameObjectWithTag("Green1Pass").GetComponent<Green1Pass>();
        green1Pass.MoveG(rb.position.x, rb.position.y);

        if (pos == 4)
        {
            rb.position = new Vector2(rb.position.x + 40, 0);
        }
        else 
        {
            rb.position = new Vector2(rb.position.x + 40, 4);
        }
        
    }

    public int getPos()
    {
        rb = GetComponent<Rigidbody2D>();
        return (int)rb.position.y;
    }







    
}
