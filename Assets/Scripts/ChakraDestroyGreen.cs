using UnityEngine;
using System.Collections;

public class ChakraDestroyGreen : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerChakra.chakraGreen = true;
            Destroy(this.gameObject);
        }
    }
}
