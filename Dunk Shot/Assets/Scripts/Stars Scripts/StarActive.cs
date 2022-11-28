using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarActive : MonoBehaviour
{
    private GameObject Number_of_stars;
    private numberofstars _numberofstars;
    private int active;
    void Start()
    {
        Number_of_stars = GameObject.Find("Number of stars");

        _numberofstars = Number_of_stars.GetComponent<numberofstars>();


        active = Random.Range(1, 11);
        if(active > 2)
        {
          this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
      {
        if (other.CompareTag("Player"))
        {
          _numberofstars.addition();

          this.gameObject.SetActive(false);
        }
      }
}
