using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green1Pass : MonoBehaviour
{
    private Rigidbody2D rb;

    

    public void MoveG(float a, float b)
    {

        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector2(a, b - 0.6f);
    }










}
