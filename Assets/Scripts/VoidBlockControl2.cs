using UnityEngine;
using System.Collections;

public class VoidBlockControl2 : MonoBehaviour
{

    private SpriteRenderer _sr;
    private EdgeCollider2D _ec;
    private BoxCollider2D _bc;

    private float _fade = .90f;

    // Use this for initialization
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _ec = GetComponent<EdgeCollider2D>();
        _bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerVoid.voidOn)
        {
            _fade += .015f;
            _sr.color = new Color(1f, 1f, 1f, _fade);
            _ec.enabled = true;
            _bc.enabled = true;
        }
        else if (PlayerVoid.voidOn)
        {
            if (_fade > 0.25)
            {
                _fade -= .15f;
            }

            _sr.color = new Color(1f, 1f, 1f, _fade);
            if (_fade < 30f)
                _ec.enabled = false;
                _bc.enabled = false;
        }
    }
}