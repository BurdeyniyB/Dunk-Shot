using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundsetting : MonoBehaviour
{
    [SerializeField] private string Load_text;
    private int load;
    private int sound_setting;

    void Update()
    {
     load = PlayerPrefs.GetInt(Load_text);
     sound_setting = PlayerPrefs.GetInt("Sound");

     if(load == 1)
     {
      if(sound_setting == 1)
        {
          GetComponent<AudioSource>().Play();
        }

        PlayerPrefs.SetInt(Load_text, 0);
      }
     }
}
