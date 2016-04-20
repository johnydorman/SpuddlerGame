using UnityEngine;
using System.Collections;

public class PlayerGlowController : MonoBehaviour {

    private SpriteRenderer _sr;
	// Use this for initialization
	void Start () {

        _sr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerVoid.voidOn)
        {
            _sr.color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            _sr.color = new Color(1f, 1f, 1f, 0f);
        }
    }
}
