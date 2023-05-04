using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditStartEquation : MonoBehaviour
{

    [SerializeField] private Text Expression_Starting_Num;
    [SerializeField] private Text CorrNum;
    StoreLevelID store;

    // Start is called before the first frame update
    void Start()
    {
        
        store = GameObject.FindGameObjectWithTag("StoreLevelID").GetComponent<StoreLevelID>();
        if (store.getLevelID() == 25)
        {
            Expression_Starting_Num.text = 0 + "";
            CorrNum.text = 0 + "";
        }
        else
        {
            Expression_Starting_Num.text = store.getLevelID() + "";
            CorrNum.text = store.getLevelID() + "";
        }
    }

    
}
