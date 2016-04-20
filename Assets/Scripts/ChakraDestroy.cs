using UnityEngine;
using System.Collections;

public class ChakraDestroy : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            PlayerChakra.chakraRed = true;
            Destroy(this.gameObject);
        }
    }
}
