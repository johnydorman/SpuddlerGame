using System;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class PlayerMovement : MonoBehaviour
    {

        private Rigidbody2D _rb;
        private bool _grounded;
        private int _jumpCount;
        private float _playerSpeed;
        public Animator anim;

        void Awake()
        {
            DontDestroyOnLoad(this);
        }

        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _jumpCount = 0;
            _playerSpeed = 10f;
        }

        void Update()
        {

            if (Input.GetKey("d")) // RIGHT
            {
                transform.localScale = new Vector3(1, 1, 1);
                if (_rb.velocity.magnitude <= Constants.PlayerMaxSpeed)
                {
                    _rb.AddForce(Vector2.right * _playerSpeed);
                }
            }

            if (Input.GetKey("a")) // LEFT
            {
                transform.localScale = new Vector3(-1, 1, 1);
                if (_rb.velocity.magnitude <= Constants.PlayerMaxSpeed)
                {
                    _rb.AddForce(Vector2.left * _playerSpeed);
                }
            }

            if (Input.GetKeyDown("w")) // JUMP
            {
                if (_grounded || _jumpCount == 1)
                {
                    _jumpCount++;
                    _rb.AddForce(Vector2.up * Constants.PlayerJumpPower, ForceMode2D.Impulse);
                }
                if (_grounded || _jumpCount == 2)
                {
                    _jumpCount++;
                    _rb.velocity = new Vector2(_rb.velocity.x, 0);
                    _rb.AddForce(Vector2.up * Constants.PlayerJumpPower, ForceMode2D.Impulse);
                }

            }

           /* //USED FOR DEBUGGINGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG
            if(Input.GetKeyDown("l"))
            {
                transform.position = new Vector3(107f, -0.5f, 1f);
            }
            if (Input.GetKeyDown("k"))
            {
                transform.position = new Vector3(113f, -2.5f, 1f);
            }
            if (Input.GetKeyDown("m"))
            {
                transform.position = new Vector3(114f, -2f, 1f);
            }
            //END OF DEBUGGING */

            //death
            if (transform.position.y < -10)
            {
                transform.position = new Vector3(-7.41f, -2.635f, 0f);
            }
        }//end void update

        void OnCollisionStay2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "floor")
            {
                _grounded = true;
                _jumpCount = 0;
            }
        }

        void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "floor")
            {
                _grounded = false;
            }
        }
    }
}