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
        UpdateTile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTile()
    {
        if (tileType == 0) // Null
        {
            sprite.color = new Color32(255, 255, 255, 255);
        }
        if (tileType == 1) // Empty
        {
            sprite.color = new Color32(129, 129, 129, 255);
        }
        if (tileType == 2) // Item
        {
            sprite.color = new Color32(0, 255, 255, 255);
        }
        if (tileType == 3) // Enemy
        {
            sprite.color = new Color32(255, 255, 51, 255);
        }
        if (tileType == 4) // Boss
        {
            sprite.color = new Color32(255, 128, 0, 255);
        }
        if (tileType == 5) // Super Boss
        {
            sprite.color = new Color32(255, 0, 0, 255);
        }
        if (tileType == 6) // NPC
        {
            sprite.color = new Color32(102, 0, 204, 255);
        }
        if (tileType == 7) // Rare Item
        {
            sprite.color = new Color32(0, 0, 255, 255);
        }
        if (tileType == 8) // Shop
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
        UpdateTile();
    }

    public void IncrementBackward()
    {
        if (nextTile != null)
        {
            tileType = nextTile.GetComponent<TileManager>().tileType;
        }
        else
        {
            int num = Random.Range(1, 1001);
            if (num <= 600)
            {
                tileType = 1;
            }
            else if (num <= 800)
            {
                tileType = 3;
            }
            else if (num <= 875)
            {
                tileType = 2;
            }
            else if (num <= 885)
            {
                tileType = 4;
            }
            else if (num <= 935)
            {
                tileType = 6;
            }
            else if (num <= 945)
            {
                tileType = 7;
            } else {
                tileType = 8;
            }
        }
        UpdateTile();
    }
}
