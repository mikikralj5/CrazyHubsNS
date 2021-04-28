using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject menuStarter;
    public GameObject menuOptions;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void OpenOptions()
    {
        menuStarter.SetActive(false);
        menuOptions.SetActive(true);
    }

}
