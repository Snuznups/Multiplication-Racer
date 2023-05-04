using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStartingScreen : MonoBehaviour
{
    public void GoToStartingScreen() 
    {
        SceneManager.LoadScene(21);

    }
}
