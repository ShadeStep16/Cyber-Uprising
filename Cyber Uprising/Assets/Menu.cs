using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    
    public string Map1;
    public string Map2;
    public string Map3;

    public void LoadMap1()
    {
        
        SceneManager.LoadScene(Map1, LoadSceneMode.Single);
        
    }

    public void LoadMap2()
    {
        
        SceneManager.LoadScene(Map2, LoadSceneMode.Single);
    }

    public void LoadMap3()
    {

        SceneManager.LoadScene(Map3, LoadSceneMode.Single);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
