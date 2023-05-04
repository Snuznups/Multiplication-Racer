using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GetCorrectAns : MonoBehaviour
{



    [SerializeField] private Text Expression_Starting_Num;
    [SerializeField] private Text Expression_Operand;
    [SerializeField] private Text Expression_Ans;
    [SerializeField] private Text Correct_Ans;
    [SerializeField] private Text Wrong1;
    [SerializeField] private Text Wrong2;
    [SerializeField] private Text ScoreText;

    private int levelID;
    private int ansPos;
    private int wrong1Pos;
    private int wrong2Pos;
    private int starting_num;
    private int operand;
    private int ans;
    private int wrongNum1;
    private int wrongNum2;
    private int score;

    TimesTablesMode runcall;
    //PlayerMovement playmove;
    MoveAns moveAns;
    MoveWrong1 moveWrong1;
    MoveWrong2 moveWrong2;
    StoreLevelID store;

    MoveCorrDisp moveCorrDisp;
    MoveWrong1Disp moveWrong1Disp;
    MoveWrong2Disp moveWrong2Disp;


    MoveTM1 moveTM1;
    MoveBackground moveBackground;

    MoveGreen mGreen;

    








    // Start is called before the first frame update
    void Start()
    {

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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Correct_Ans"))
        {
            store = GameObject.FindGameObjectWithTag("StoreLevelID").GetComponent<StoreLevelID>();
            store.upScore();
            score = store.getScore();
            ScoreText.text = "Score: " + score;
            runcall = GameObject.FindGameObjectWithTag("TimesTablesMode").GetComponent<TimesTablesMode>();
            //playmove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
            

            levelID = store.getLevelID();


            switch (levelID)
            {
                case 1:
                    runcall.Table1();
                    break;
                case 2:
                    runcall.Table2();
                    break;
                case 3:
                    runcall.Table3();
                    break;
                case 4:
                    runcall.Table4();
                    break;
                case 5:
                    runcall.Table5();
                    break;
                case 6:
                    runcall.Table6();
                    break;
                case 7:
                    runcall.Table7();
                    break;
                case 8:
                    runcall.Table8();
                    break;
                case 9:
                    runcall.Table9();
                    break;
                case 10:
                    runcall.Table10();
                    break;
                case 11:
                    runcall.Table11();
                    break;
                case 12:
                    runcall.Table12();
                    break;
                case 13:
                    runcall.Table13();
                    break;
                case 14:
                    runcall.Table14();
                    break;
                case 15:
                    runcall.Table15();
                    break;
                case 16:
                    runcall.Table16();
                    break;
                case 17:
                    runcall.Table17();
                    break;
                case 18:
                    runcall.Table18();
                    break;
                case 19:
                    runcall.Table19();
                    break;
                case 20:
                    runcall.Table20();
                    break;
                case 25:
                    runcall.TableM();
                    break;


                default:
                    Debug.Log("Case Defaulted!!!");
                    runcall.Table5();
                    break;
            }






            starting_num = runcall.getStarting_num();
            operand = runcall.getOperand();
            ans = runcall.getAns();
            wrongNum1 = runcall.getWrong1();
            wrongNum2 = runcall.getWrong2();


            Expression_Starting_Num.text = "" + starting_num;
            Expression_Operand.text = "" + operand;
            Expression_Ans.text = "?";
            Correct_Ans.text = "" + ans;
            Wrong1.text = ""+wrongNum1;
            Wrong2.text = ""+wrongNum2;



            //Move Cherry

            moveAns = GameObject.FindGameObjectWithTag("Correct_Ans").GetComponent<MoveAns>();
            moveAns.Move();
            ansPos = moveAns.getPos();
            moveWrong1 = GameObject.FindGameObjectWithTag("Wrong1").GetComponent<MoveWrong1>();
            moveWrong1.Move(ansPos);
            wrong1Pos = moveWrong1.getPos();
            moveWrong2 = GameObject.FindGameObjectWithTag("Wrong2").GetComponent<MoveWrong2>();
            moveWrong2.Move(ansPos, wrong1Pos);
            wrong2Pos = moveWrong2.getPos();

            moveCorrDisp = GameObject.FindGameObjectWithTag("CorrDisp").GetComponent<MoveCorrDisp>();
            moveCorrDisp.Move(ansPos);
            moveWrong1Disp = GameObject.FindGameObjectWithTag("Wrong1Disp").GetComponent<MoveWrong1Disp>();
            moveWrong1Disp.Move(wrong1Pos);
            moveWrong2Disp = GameObject.FindGameObjectWithTag("Wrong2Disp").GetComponent<MoveWrong2Disp>();
            moveWrong2Disp.Move(wrong2Pos);









            moveTM1 = GameObject.FindGameObjectWithTag("Terrain").GetComponent<MoveTM1>();
            moveTM1.Move();
            moveBackground = GameObject.FindGameObjectWithTag("Background").GetComponent<MoveBackground>();
            moveBackground.Move();
            moveBackground = GameObject.FindGameObjectWithTag("RoadTM").GetComponent<MoveBackground>();
            moveBackground.Move();
            mGreen = GameObject.FindGameObjectWithTag("GreenCorr").GetComponent<MoveGreen>();
            mGreen.Move();
            mGreen = GameObject.FindGameObjectWithTag("Green1").GetComponent<MoveGreen>();
            mGreen.Move();
            mGreen = GameObject.FindGameObjectWithTag("Green2").GetComponent<MoveGreen>();
            mGreen.Move();

        }



        if (collision.gameObject.CompareTag("Wrong1") || collision.gameObject.CompareTag("Wrong2")) 
        {
            
        }





















    }
}
