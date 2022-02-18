using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject tiles;
    public GameObject prevTile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (prevTile.GetComponent<TileManager>().tileType != 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                MoveBackward();
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            MoveForward();
        }
    }

    void MoveForward()
    {
        int children = tiles.transform.childCount;
        for (int i = 0; i < children; i++)
        {
            GameObject tile = tiles.transform.GetChild(i).gameObject;
            tile.GetComponent<TileManager>().IncrementBackward();
        }
    }

    void MoveBackward()
    {
        int children = tiles.transform.childCount;
        for (int i = children - 1; i >= 0; i--)
        {
            GameObject tile = tiles.transform.GetChild(i).gameObject;
            tile.GetComponent<TileManager>().IncrementForward();
        }
    }
}
