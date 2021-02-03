using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string MenuScene;
    public GameObject gm;


    // Update is called once per frame
    void Update()
    {
        gm = GameObject.Find("GameManager");


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(gm);
            SceneManager.LoadScene(MenuScene, LoadSceneMode.Single);
        }
    }

}
