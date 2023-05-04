using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private int levelID;
    private float playerSpeed;
    MoveSign mSign;
    











    //TimesTablesMode runcall;

    // Start is called before the first frame update
    void Start()
    {


        levelID = SceneManager.GetActiveScene().buildIndex;
        


        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector2(0f, -.5f);
        rb.velocity = new Vector2(8f, 0f);
        playerSpeed = rb.velocity.x;

        /*Debug.Log("TE");
        runcall = GameObject.FindGameObjectWithTag("TimesTablesMode").GetComponent<TimesTablesMode>();
        runcall.Table1();
        runcall.Table2();
        runcall.Table3();
        runcall.Table4();
        runcall.Table5();
        runcall.Table6();
        runcall.Table7();
        runcall.Table8();
        runcall.Table9();
        runcall.Table10();
        runcall.Table11();
        runcall.Table12();
        runcall.Table13();
        runcall.Table14();
        runcall.Table15();
        runcall.Table16();
        runcall.Table17();
        runcall.Table18();
        runcall.Table19();
        runcall.Table20();
        Debug.Log("ST");
        */


    }

    // Update is called once per frame
    void Update()
    {


        playerSpeed += 0.1f * Time.deltaTime;
        rb.velocity = new Vector2(playerSpeed, 0f);

        if (Input.GetKeyDown("down") && rb.position.y>-3f)
        {
            rb.position = new Vector2(rb.position.x, rb.position.y-4f);


        }
        if (Input.GetKeyDown("up") && rb.position.y<3f)
        {
            rb.position = new Vector2(rb.position.x, rb.position.y+4f);


        }
        mSign = GameObject.FindGameObjectWithTag("SignTM").GetComponent<MoveSign>();
        mSign.Move(transform.position.x + 14f);

    }



    public int getLevelID() 
    {
        return levelID;
    }

}
