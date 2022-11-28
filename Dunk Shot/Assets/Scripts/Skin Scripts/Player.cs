using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] private SkinManager skinManager;
  private float smoothTime = 0.1f;
  private float playerSPeed = 10f;
  private Vector3 velocity = Vector3.zero;
  private Vector3 direction;
  private Rigidbody2D playerBody;
  private const string SelectedSkin = "SelectedSkin";

  void Start()
  {
    int pr = PlayerPrefs.GetInt(SelectedSkin, 0);
    GetComponent<SpriteRenderer>().sprite = skinManager.GetSelectedSkin().sprite;
    Debug.Log("Selected chudick = " + pr);
    playerBody = GetComponent<Rigidbody2D>();
  }

  // Inputs are read here
  void Update()
  {
      GetComponent<SpriteRenderer>().sprite = skinManager.GetSelectedSkin().sprite;
  }
}
