using UnityEngine;
using System.Collections;

public class ChakraRotation : MonoBehaviour
{

    private bool smaller = false;
    private SpriteRenderer _sr;

    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "chakraRed")
        {
            if (!PlayerChakra.chakraRed)
            {
                _sr.enabled = false;
            }
            else
            {
                _sr.enabled = true;
            }
        }
        else if (gameObject.tag == "chakraBlue")
        {
            if (!PlayerChakra.chakraBlue)
            {
                _sr.enabled = false;
            }
            else
            {
                _sr.enabled = true;
            }
        }
        else if (gameObject.tag == "chakraGreen")
        {
            if (!PlayerChakra.chakraGreen)
            {
                _sr.enabled = false;
            }
            else
            {
                _sr.enabled = true;
            }
        }

        if (transform.localScale.x < -0.8f)
            smaller = false;
        if (transform.localScale.x >= 0.8f)
            smaller = true;

        if (smaller)
            transform.localScale -= new Vector3(0.01f, 0, 0);
        else
            transform.localScale += new Vector3(0.01f, 0, 0);
    }
}