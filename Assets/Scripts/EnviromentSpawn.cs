using UnityEngine;
using System.Collections;
using System.Linq;

public class EnviromentSpawn : MonoBehaviour
{
    public GameObject floor;
    public GameObject voidFloor;
    public GameObject voidFloor2;
    public static int mapInt;

    // Use this for initialization
    void Start()
    {
        int[] floortiles = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1};

        for (int x = 0; x < floortiles.Length; x++)
        {
            if (floortiles[x] == 2)
               {
                   Instantiate(voidFloor2, new Vector3(-9 + (float)(x * 1.28), -4.4f, 0), Quaternion.identity);

               }
                else if (floortiles[x] == 1)
               {
                Instantiate(floor, new Vector3(-9 + (float)(x * 1.28), -4.4f, 0), Quaternion.identity);

               }
               else if (floortiles[x] == 0)
               {
                    Instantiate(voidFloor, new Vector3(-9 + (float)(x * 1.28), -4.4f, 0), Quaternion.identity);
               } else if (floortiles[x] == 0)
               {
                    Instantiate(voidFloor, new Vector3(-9 + (float)(x * 1.28), -4.4f, 0), Quaternion.identity);
               }
            }
        }
}
