using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadsetting : MonoBehaviour
{
    [SerializeField] private string Save_text;
    private int _save;
    [SerializeField] private bool active;

    void Start()
    {
    _save = PlayerPrefs.GetInt(Save_text);
    
          if(_save == 0)
          {
             if (active == true)
             {
              _save = 1;
              PlayerPrefs.SetInt(Save_text, 1);
             }
             else
             {
              _save = 2;
              PlayerPrefs.SetInt(Save_text, 2);
             }
          }
    }
}
