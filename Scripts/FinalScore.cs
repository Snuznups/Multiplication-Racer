using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    [SerializeField] private Text ScoreText;
    [SerializeField] private Text GameModeText;
    private int score;
    StoreLevelID store;
    private int levelID;

    // Start is called before the first frame update
    void Start()
    {
        store = GameObject.FindGameObjectWithTag("StoreLevelID").GetComponent<StoreLevelID>();
        score = store.getScore();

        ScoreText.text = "Your score is " + score;

        store.setScore(0);


        levelID = store.getLevelID();
        if (levelID == 25)
        {
            GameModeText.text = "Game Mode: Mixed Multiplication";
        }
        else 
        {
            GameModeText.text = levelID + "s Times Tables";
        }



    }

    
}
