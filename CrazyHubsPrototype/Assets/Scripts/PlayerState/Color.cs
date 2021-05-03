using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color : MonoBehaviour
{
    public ColorState state;

    public Text blueText;
    public Text redText;
    public Text yellowText;

    public Material skyBoxBlue;
    public Material skyBoxRed;
    public Material skyBoxYellow;

    public Material playerBlue;
    public Material playerRed;
    public Material playerYellow;

    public GameObject yellowParticle;
    public GameObject redParticle;
    public GameObject blueParticle;

    public int cubesToCollect;



    void Start()
    {
        state = new ColorRed();
        InvokeRepeating("ChangeColor", 5, 5);
        cubesToCollect = PlayerPrefs.GetInt("CubesToCollect",5);
    }
    void ChangeColor()
    {

        state.ChagneColor(this,gameObject);
        FindObjectOfType<SoundEffectManager>().PlaySound("ColorChange");
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Platform is" + other.tag);
        Debug.Log("State is" + state.GetType().Name);
        Debug.Log("Speed is" + gameObject.GetComponent<PlayerController>().ForwardSpeed);
        if (other.CompareTag(state.GetType().Name))
        {
            state.CollisionChangeUp(gameObject);

            Debug.Log("speedup");
        }
        else if (state.GetType().Name == "ColorFree")
        {
            state.CollisionChangeUp(gameObject);
            Debug.Log("speedup in ColorFree state");
        }
        else if (!other.CompareTag(state.GetType().Name))
        {
            if (!other.CompareTag("RedPickup") && !other.CompareTag("BluePickup") && !other.CompareTag("YellowPickup"))
            {
                state.CollisionChangeDown(gameObject);
                Debug.Log("slowed");
            }
                
        }
        
      
       
    }

    public void ShowBlueParticle(GameObject player)
    {
        Instantiate(blueParticle,player.transform.position,player.transform.rotation);
    }

    public void ShowRedParticle(GameObject player)
    {
        Instantiate(redParticle, player.transform.position, player.transform.rotation);
    }

    public void ShowYellowParticle(GameObject player)
    {
        Instantiate(yellowParticle, player.transform.position, player.transform.rotation);
    }
}
