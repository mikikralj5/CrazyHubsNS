using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject menuStarter;
    public GameObject menuOptions;

    public float easySpeed;
    public float easySlow;

    public float mediumSpeed;
    public float mediumSlow;

    public float hardSpeed;
    public float hardSlow;
    
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

        PlayerPrefs.SetFloat("PlayerSlow", easySlow);
        PlayerPrefs.SetFloat("PlayerSpeedup", easySpeed);

        menuStarter.SetActive(true);
        menuOptions.SetActive(false);
    }

    public void MedimumOption()
    {
        PlayerPrefs.SetFloat("PlayerSlow", mediumSlow);
        PlayerPrefs.SetFloat("PlayerSpeedup", mediumSpeed);

        menuStarter.SetActive(true);
        menuOptions.SetActive(false);
    }

    public void HardOption()
    {
        PlayerPrefs.SetFloat("PlayerSlow", hardSlow);
        PlayerPrefs.SetFloat("PlayerSpeedup", hardSpeed);

        menuStarter.SetActive(true);
        menuOptions.SetActive(false);

    }

    public void OpenOptions()
    {
        menuStarter.SetActive(false);
        menuOptions.SetActive(true);
    }

}
