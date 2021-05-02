using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    public GameObject endMenu;
    public GameObject player;


    private void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -3)
        {
            EndGameMenu();
        }
    }

    private void EndGameMenu()
    {
        endMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PlayAgain()
    {
        endMenu.SetActive(false);
        SceneManager.LoadScene("Level");
    }

    public void BackToMenu()
    {
        endMenu.SetActive(false);       
        SceneManager.LoadScene("MenuUI");
        
    }
}

