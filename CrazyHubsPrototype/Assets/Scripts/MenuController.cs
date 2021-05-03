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
    public float minEasySpeed;
    public int easyCubesToCollect;

    public float mediumSpeed;
    public float mediumSlow;
    public float minMediumSpeed;
    public int mediumCubesToCollect;

    public float hardSpeed;
    public float hardSlow;
    public float minHardSpeed;
    public int hardCubesToCollect;



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

    public void EasyOption()
    {

        PlayerPrefs.SetFloat("PlayerSlow", easySlow);
        PlayerPrefs.SetFloat("PlayerSpeedup", easySpeed);
        PlayerPrefs.SetFloat("MinSpeed", minEasySpeed);
        PlayerPrefs.SetInt("CubesToCollect", easyCubesToCollect);


        menuStarter.SetActive(true);
        menuOptions.SetActive(false);
    }

    public void MedimumOption()
    {
        PlayerPrefs.SetFloat("PlayerSlow", mediumSlow);
        PlayerPrefs.SetFloat("PlayerSpeedup", mediumSpeed);
        PlayerPrefs.SetFloat("MinSpeed", minMediumSpeed);
        PlayerPrefs.SetInt("CubesToCollect", mediumCubesToCollect);
        menuStarter.SetActive(true);
        menuOptions.SetActive(false);
    }

    public void HardOption()
    {
        PlayerPrefs.SetFloat("PlayerSlow", hardSlow);
        PlayerPrefs.SetFloat("PlayerSpeedup", hardSpeed);
        PlayerPrefs.SetFloat("MinSpeed", minHardSpeed);
        PlayerPrefs.SetInt("CubesToCollect", hardCubesToCollect);
        menuStarter.SetActive(true);
        menuOptions.SetActive(false);

    }

   

}
