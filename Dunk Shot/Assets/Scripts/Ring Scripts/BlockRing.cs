using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRing : MonoBehaviour
{
    [SerializeField] private GameObject _block_ring;
    private int _active_manager;

    void Awake()
    {
      PlayerPrefs.SetInt("BlockRing", 1);
    }

    void Update()
    {
        _active_manager = PlayerPrefs.GetInt("BlockRing");
        Debug.Log("PlayerPrefs.GetInt(BlockRing) = " + _active_manager);

        if(_active_manager == 1)
        {
          Active();
        }
        else
        {
          Block();
        }
    }

    void Active()
    {
      _block_ring.SetActive(true);
    }

    void Block()
    {
      _block_ring.SetActive(false);
    }
}
