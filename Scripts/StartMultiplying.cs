using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMultiplying : MonoBehaviour
{
    // Start is called before the first frame update


    StoreLevelID store;
    private int levelID;



    public void GoTOGame()
    {
        store = GameObject.FindGameObjectWithTag("StoreLevelID").GetComponent<StoreLevelID>();
        levelID = store.getLevelID();


        

        switch (levelID)
        {
            case 1:
                SceneManager.LoadScene(1);
                break;
            case 2:
                SceneManager.LoadScene(2);
                break;
            case 3:
                SceneManager.LoadScene(3);
                break;
            case 4:
                SceneManager.LoadScene(4);
                break;
            case 5:
                SceneManager.LoadScene(5);
                break;
            case 6:
                SceneManager.LoadScene(6);
                break;
            case 7:
                SceneManager.LoadScene(7);
                break;
            case 8:
                SceneManager.LoadScene(8);
                break;
            case 9:
                SceneManager.LoadScene(9);
                break;
            case 10:
                SceneManager.LoadScene(10);
                break;
            case 11:
                SceneManager.LoadScene(11);
                break;
            case 12:
                SceneManager.LoadScene(12);
                break;
            case 13:
                SceneManager.LoadScene(13);
                break;
            case 14:
                SceneManager.LoadScene(14);
                break;
            case 15:
                SceneManager.LoadScene(15);
                break;
            case 16:
                SceneManager.LoadScene(16);
                break;
            case 17:
                SceneManager.LoadScene(17);
                break;
            case 18:
                SceneManager.LoadScene(18);
                break;
            case 19:
                SceneManager.LoadScene(19);
                break;
            case 20:
                SceneManager.LoadScene(20);
                break;
            case 25:
                SceneManager.LoadScene(25);
                break;




            default:
                Debug.Log("Case Defaulted!!!");
                SceneManager.LoadScene(1);
                break;
        }





    }

    
}
