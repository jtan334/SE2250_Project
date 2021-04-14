using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Collect : MonoBehaviour
{
    public static int count;
    public Tilemap highlightMap;

    void Awake()
    {
        if (count >= 3)
        {
            highlightMap.SetTile(new Vector3Int(-20, 0, 0), null);
            highlightMap.SetTile(new Vector3Int(-20, -1, 0), null);
            highlightMap.SetTile(new Vector3Int(-20, -2, 0), null);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectible" & count < 3)
        {
            count++;
            Destroy(collision.gameObject);
            print(count);
        }
    }

    void Update()
    {
        if (count >= 3 & count < 999)
        {
            highlightMap.SetTile(new Vector3Int(-20, 0, 0), null);
            highlightMap.SetTile(new Vector3Int(-20, -1, 0), null);
            highlightMap.SetTile(new Vector3Int(-20, -2, 0), null);
            count = count + 1000;
        }
    }
}
