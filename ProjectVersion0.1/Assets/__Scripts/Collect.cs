using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Collect : MonoBehaviour
{
    public int count;
    public Tile highlightTile;
    public Tilemap highlightMap;

    private Vector3Int Top = new Vector3Int(-19,1,0);
    private Vector3Int Middle = new Vector3Int(-19, 0, 0);
    private Vector3Int Bottom = new Vector3Int(-19, -1, 0);

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectible")
        {
            count++;
            Destroy(collision.gameObject);
            print(count);
        }
    }

    void Update()
    {
        if (count == 3 | count == 4)
        {
            print("BOSS TIME");
            highlightMap.SetTile(Top, null);
            highlightMap.SetTile(Middle, null);
            highlightMap.SetTile(Bottom, null);
            count=count + 100;
        }
    }
}
