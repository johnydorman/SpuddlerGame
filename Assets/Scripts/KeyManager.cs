using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{

    public static GameObject QKey;
    public static GameObject QKey1;
    public static GameObject QKey2;


    void Start()
    {
        QKey = GameObject.Find("QKey1");
        QKey1 = GameObject.Find("QKey2");
        QKey2 = GameObject.Find("QKey3");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.name == "standingstone1")
            {
                QKey.GetComponent<SpriteRenderer>().enabled = true;
            }
            if (gameObject.name == "standingstone2")
            {
                QKey1.GetComponent<SpriteRenderer>().enabled = true;

            }
            if (gameObject.name == "standingstone3")
            {
                QKey2.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.name == "standingstone1")
            {
                QKey.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (gameObject.name == "standingstone2")
            {
                QKey1.GetComponent<SpriteRenderer>().enabled = false;

            }
            if (gameObject.name == "standingstone3")
            {
                QKey2.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

}