using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject nextTile;
    public GameObject prevTile;
    public int tileType;
    private SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        UpdateColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(prevTile != null)
            {
                tileType = prevTile.GetComponent<TileManager>().tileType;
            }
            else
            {
                tileType = 0;
            }
            UpdateColor();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tileType = nextTile.GetComponent<TileManager>().tileType;
            UpdateColor();
        }
    }

    void UpdateColor()
    {
        if (tileType == 0)
        {
            sprite.color = new Color(255, 255, 255);
        }
        if (tileType == 1)
        {
            sprite.color = new Color(60, 120, 50);
        }
    }
}
