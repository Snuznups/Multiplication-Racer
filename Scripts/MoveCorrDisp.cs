using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCorrDisp : MonoBehaviour
{
    private RectTransform rt;
    private Rigidbody2D rb;
    private int pos;
    private float y;


    public void Move(int a)
    {
        rb = GetComponent<Rigidbody2D>();
        rt = GetComponent<RectTransform>();


        pos = a;
        
        if (pos == 4) { y = 512; }
        else if (pos == 0) { y = 296; }
        else { y = 80; }

        
        //rb.position = new Vector2(rb.position.x, y);
        rt.position = new Vector2(rt.position.x, y);
        
    }


}
