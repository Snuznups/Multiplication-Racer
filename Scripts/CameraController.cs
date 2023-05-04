using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    MoveSign mSign;


    StoreLevelID store;
    private int levelID;

    // Start is called before the first frame update
    void Start()
    {

        store = GameObject.FindGameObjectWithTag("StoreLevelID").GetComponent<StoreLevelID>();
        levelID = store.getLevelID();
        if (levelID == 0)
        {
            GoToLevelSelect();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(player.transform.position.x+14f, transform.position.y, -10f);



        
    }




    private void GoToLevelSelect()
    {
        SceneManager.LoadScene(21);
    }


}
