using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject nextTile;
    public GameObject prevTile;
    public int tileType;
    SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        UpdateColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateColor()
    {
        if (tileType == 0)
        {
            sprite.color = new Color32(255, 255, 255, 255);
        }
        if (tileType == 1)
        {
            sprite.color = new Color32(60, 120, 50, 255);
        }
        if (tileType == 2)
        {
            sprite.color = new Color32(84, 50, 32, 255);
        }
    }

    public void IncrementForward()
    {
        if (prevTile != null)
        {
            tileType = prevTile.GetComponent<TileManager>().tileType;
        }
        else
        {
            tileType = 0;
        }
        UpdateColor();
    }

    public void IncrementBackward()
    {
        if (nextTile != null)
        {
            tileType = nextTile.GetComponent<TileManager>().tileType;
        }
        else
        {
            tileType = Random.Range(1, 3);
        }
        UpdateColor();
    }
}
