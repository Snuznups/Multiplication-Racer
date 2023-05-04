using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAns : MonoBehaviour
{

    private int rando;
    private int y;


    private Rigidbody2D rb;
    GreenPass greenPass;


    public void Move()
    {
        rb = GetComponent<Rigidbody2D>();
        greenPass = GameObject.FindGameObjectWithTag("GreenPass").GetComponent<GreenPass>();
        greenPass.MoveG(rb.position.x, rb.position.y);
        
        rando = Random.Range(0, 3);

        if (rando == 0) { y = -4; }
        if (rando == 1) { y = 0; }
        if (rando == 2) { y = 4; }
        rb.position = new Vector2(rb.position.x+40, y);
    }

    public int getPos()
    {
        rb = GetComponent<Rigidbody2D>();
        return (int)rb.position.y;
    }























}
