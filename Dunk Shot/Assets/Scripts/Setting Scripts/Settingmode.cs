using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settingmode : MonoBehaviour
{
    [SerializeField] private GameObject yes;
    [SerializeField] private GameObject no;
    [SerializeField] private string Save_text;
    private int _save;

    void Update()
    {
     _save = PlayerPrefs.GetInt(Save_text);

      if(_save == 1)
      {
        yes.SetActive(true);
        no.SetActive(false);
      }

      if(_save == 2)
      {
        yes.SetActive(false);
        no.SetActive(true);
      }
    }

    public void Mode_yes()
    {
      _save = 2;
      PlayerPrefs.SetInt(Save_text, 2);
      yes.SetActive(false);
      no.SetActive(true);
    }

    public void Mode_no()
    {
      _save = 1;
      PlayerPrefs.SetInt(Save_text, 1);
      yes.SetActive(true);
      no.SetActive(false);
    }
}
