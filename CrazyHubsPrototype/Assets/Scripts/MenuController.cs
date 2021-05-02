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

    public void EasyOption()
    {
        //PlayerPrefs.SetFloat("PlayerSlow", 0.6f);
        //PlayerPrefs.SetFloat("PlayerSpeedup", 0.5f);

        PlayerPrefs.SetFloat("PlayerSlow", 3f);
        PlayerPrefs.SetFloat("PlayerSpeedup", 7f);

        menuStarter.SetActive(true);
        menuOptions.SetActive(false);
    }

    public void MedimumOption()
    {
        PlayerPrefs.SetFloat("PlayerSlow", 0.8f);
        PlayerPrefs.SetFloat("PlayerSpeedup", 0.4f);

        menuStarter.SetActive(true);
        menuOptions.SetActive(false);
    }

    public void HardOption()
    {
        PlayerPrefs.SetFloat("PlayerSlow", 0.9f);
        PlayerPrefs.SetFloat("PlayerSpeedup", 0.3f);

        menuStarter.SetActive(true);
        menuOptions.SetActive(false);

    }

    public void OpenOptions()
    {
        menuStarter.SetActive(false);
        menuOptions.SetActive(true);
    }

}
