using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour
{

    public GameObject VoidTutorial;

	// Use this for initialization
	void Start ()
	{
        StartCoroutine(func());
	}

    private IEnumerator func()
    {
        VoidTutorial.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(3f);
        VoidTutorial.GetComponent<SpriteRenderer>().enabled = false;
    }

}
