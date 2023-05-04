using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{

    [SerializeField] private Text TimesTablesText;

    StoreLevelID store;
    private int levelID;

    // Start is called before the first frame update
    void Start()
    {
        TimesTablesText.text = "lol?";
        store = GameObject.FindGameObjectWithTag("StoreLevelID").GetComponent<StoreLevelID>();
        levelID = store.getLevelID();
        if (levelID == 25) 
        {
            TimesTablesText.text = "Mixed Multiplication";
        }
        else 
        {
            TimesTablesText.text = levelID + "s Times Tables";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
