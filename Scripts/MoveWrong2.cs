using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWrong2 : MonoBehaviour
{


    private Rigidbody2D rb;
    private int pos;
    private int pos2;
    Green2Pass green2Pass;


    public void Move(int a, int b)
    {
        pos = a;
        pos2 = b;

        rb = GetComponent<Rigidbody2D>();
        green2Pass = GameObject.FindGameObjectWithTag("Green2Pass").GetComponent<Green2Pass>();
        green2Pass.MoveG(rb.position.x, rb.position.y);


        if (pos != -4 && pos2 != -4)
        {
            rb.position = new Vector2(rb.position.x + 40, -4);
        }
        else if (pos != 0 && pos2 != 0)
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
