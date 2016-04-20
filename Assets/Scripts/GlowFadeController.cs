using UnityEngine;
using System.Collections;

public class GlowFadeController : MonoBehaviour
{
    private float _fade;
    public float fadeSpeed = 1f;
    public bool fadeIn = true;
    public static bool character = false;
    public SpriteRenderer text;

    // Use this for initialization

    // Invisible on Awake
    void Awake()
    {
        //text.color = new Color(1f, 1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeIn && !character)
        {
            _fade += .015f;
            if (_fade > 0.9f)
                fadeIn = false;
        } else if (!fadeIn && !character)
        {
            _fade -= .015f;
            if (_fade < 0.2f)
                fadeIn = true;
        } else if(character)
        {
            _fade = 0.9f;
        }
        text.color = new Color(1f, 1f, 1f, _fade);
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            character = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            character = false;
        }
    }
}