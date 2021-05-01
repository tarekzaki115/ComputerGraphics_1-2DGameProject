using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteScript : MonoBehaviour
{

    public GameObject muteButton;
    public GameObject unMuteButton;



    // Start is called before the first frame update
    void Start()
    {
        setSound();
    }

    public void toggleMute()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }

        setSound();

    }

    private void setSound()
    {
        if(PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            muteButton.SetActive(true);
            unMuteButton.SetActive(false);
        }
        else
        {
            AudioListener.volume = 0;
            muteButton.SetActive(false);
            unMuteButton.SetActive(true);
        }
    }

}
