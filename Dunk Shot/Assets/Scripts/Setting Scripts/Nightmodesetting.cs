using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nightmodesetting : MonoBehaviour
{
    private GameObject _cameraObj;
    private Camera _camera;
    private int active;

    private Color _light_color = new Color(0.85f, 0.85f, 0.85f);
    private Color _night_color = new Color(0.35f, 0.35f, 0.35f);

    void Start()
    {
      _cameraObj = GameObject.Find("Main Camera");
      _camera = _cameraObj.GetComponent<Camera>();
    }
    void Update()
    {
        active = PlayerPrefs.GetInt("Night mode");
        if(active == 1)
        {
          _camera.backgroundColor = _night_color;
        }

        if(active == 2)
        {
          _camera.backgroundColor = _light_color;
        }
    }
}
