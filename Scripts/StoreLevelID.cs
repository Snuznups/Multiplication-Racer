using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreLevelID : MonoBehaviour
{
    private int levelID;
    private int score = 0;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void setLevelID(int a) 
    {
        levelID = a;
    }

    public int getLevelID() 
    {
        return levelID;
    }

    public void upScore()
    {
        score++; ;
    }
    public void setScore(int a)
    {
        score = 0;
    }

    public int getScore()
    {
        return score;
    }





}
