using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTiler : MonoBehaviour
{
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        int backgroundSize = 15;
        for (int y = -backgroundSize; y <= backgroundSize; ++y)
        {
            for (int x = -backgroundSize; x <= backgroundSize; ++x)
            {
                GameObject newTile = Instantiate(tile, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
}
