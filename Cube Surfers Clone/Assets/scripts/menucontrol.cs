using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class menucontrol : MonoBehaviour
{


    public void startbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void quitGame()
    {
        
        Application.Quit();
    }
    public void backMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
