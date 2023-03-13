using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountBallInRing : MonoBehaviour
{
    public static CountBallInRing instance;

	void Awake () {
        if (instance == null)
            instance = this;
	}

     public Text count_in_ring;
     private int count;

     void Start()
     {
       count = PlayerPrefs.GetInt("CountBallInRing");
       CountWrite("number of hits before the game - ");
     }

     public void CountPlus()
     {
       count++;
       PlayerPrefs.SetInt("CountBallInRing", count);
     }

     public void CountWrite(string t)
     {
       count_in_ring.text = t + count.ToString();
     }
}
