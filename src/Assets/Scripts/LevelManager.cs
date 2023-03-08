using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public bool isMenu = false; //check if scene is main menu
    private int level; //level number

    void Start()
    {
        //check if level number has been saved and go there
        if (PlayerPrefs.HasKey("currentLevel"))
        {
            level = PlayerPrefs.GetInt("currentLevel");
        }

        //if on main menu jump to saved level
        if (isMenu)
        {
            LoadLevel();
        }
    }

    //jump to saved level number
    public void LoadLevel()
    {
        SceneManager.LoadScene(level);
    }

    //increase level number, save level number and go to next level
    public void NextLevel()
    {
        level += 1;
        PlayerPrefs.SetInt("currentLevel", level);
        LoadLevel();
    }

    //restart current level
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}