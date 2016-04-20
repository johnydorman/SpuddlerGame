﻿using UnityEngine;
using System.Collections;

public class LevelThreeEnviroment : MonoBehaviour
{

    public GameObject floor;
    public GameObject voidFloor;
    public GameObject voidFloor2;

    int[][] floortiles = new int[][]
    {
                                                                                /* 1 normal block
                                                                                3 purple void
                                                                                2 blue void
                                                                                5 empty
                                                                                */
        new int [] {5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1},
        new int [] {5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1},
        new int [] {5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,1},
        new int [] {5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,3,3,3,3,3,5,5,5,5,5,5,5,5,5,5,5,5,3,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,3,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,1},
        new int [] {5,5,5,5,5,5,5,5,5,5,5,5,5,2,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,3,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,3,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,1},
        new int [] {5,5,5,5,5,5,5,5,5,5,3,3,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,3,5,5,5,5,5,5,5,5,3,5,5,5,2,2,2,5,5,5,1,5,5,5,5,5,5,5,5,5,5,5,5,2,2,2,2,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,1},
        new int [] {5,5,5,5,5,5,2,2,5,5,5,5,5,5,5,5,5,5,5,5,5,3,3,5,5,5,5,5,5,5,5,5,5,5,3,5,5,5,5,5,5,5,3,3,5,5,5,5,5,5,5,5,5,1,5,5,5,5,5,5,5,5,5,3,3,5,5,5,5,5,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,5,5,5,5,5,5,5,5,5,5,5,1},
        new int [] {1,1,1,1,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,2,2,2,2,5,5,1,2,2,2,1,1,1,3,3,3,5,5,5,5,5,5,5,5,5,1,3,3,1,1,1,1,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,2,2,2,2,2,5,5,5,5,3,3,3,3,3,5,5,2,3,3,3,3,1,1,1,1,1,1,1,1}
    };


    // Use this for initialization
    void Start()
    {


        for (int y = 0; y < floortiles.Length; y++)
        {
            for (int x = 0; x < floortiles[0].Length; x++)
            {
                if (floortiles[y][x] == 1)
                {
                    Instantiate(floor, new Vector3(-9 + (float)(x * 1.28), -(-4.4f + (float)(y * 1.28)), 0), Quaternion.identity);

                }
                else if (floortiles[y][x] == 3)
                {
                    Instantiate(voidFloor, new Vector3(-9 + (float)(x * 1.28), -(-4.4f + (float)(y * 1.28)), 0), Quaternion.identity);
                }
                else if (floortiles[y][x] == 2)
                {

                    Instantiate(voidFloor2, new Vector3(-9 + (float)(x * 1.28), -(-4.4f + (float)(y * 1.28)), 0), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}