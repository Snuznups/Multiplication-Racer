using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimesTableText : MonoBehaviour
{




    [SerializeField] private Text TimesTablesText;

    StoreLevelID store;
    private int levelID;











    // Start is called before the first frame update
    void Start()
    {

        store = GameObject.FindGameObjectWithTag("StoreLevelID").GetComponent<StoreLevelID>();
        levelID = store.getLevelID();
        TimesTablesText.text = levelID + "s Times Tables";

    }

    
}
