using UnityEngine;
using System.Collections;

public class ChakraBlueDestroy : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerChakra.chakraBlue = true;
            Destroy(this.gameObject);
        }
    }
}
