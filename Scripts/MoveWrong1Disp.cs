using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWrong1Disp : MonoBehaviour
{
    private Rigidbody2D rb;
    private int pos;
    private int y;

    public void Move(int a)
    {
        rb = GetComponent<Rigidbody2D>();


        pos = a;

        if (pos == 4) { y = 512; }
        else if (pos == 0) { y = 296; }
        else { y = 80; }

        rb.position = new Vector2(rb.position.x, y);
    }


}
