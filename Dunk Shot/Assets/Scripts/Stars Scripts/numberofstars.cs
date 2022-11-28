using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class numberofstars : MonoBehaviour
{
    [SerializeField] private Text _starText;
    private int star;

    void Start()
    {
      star = PlayerPrefs.GetInt("number of stars");

      _starText.text = star.ToString();
    }

    public void addition()
    {
      star++;
      _starText.text = star.ToString();
      PlayerPrefs.SetInt("number of stars", star);

      PlayerPrefs.SetInt("Star click", 1);
    }
}
