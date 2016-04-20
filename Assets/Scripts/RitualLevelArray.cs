using UnityEngine;
using System.Collections;
using System.Linq;

public class RitualLevelArray : MonoBehaviour
{
    public GameObject floor;
    public static int mapInt;

    // Use this for initialization
    void Start()
    {
        int[] floortiles = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

        for (int x = 0; x < floortiles.Length; x++)
        {
            if (floortiles[x] == 1)
            {
                Instantiate(floor, new Vector3(-9 + (float)(x * 1.28), -4.4f, 0), Quaternion.identity);

            }

        }
    }
}
