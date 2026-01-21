using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Farmlike.Game
{
    public class PlayerController : MonoBehaviour
    {
        private Animator animator;
        public int speed = 1;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

        void FixedUpdate()
        {
            Move();
        }

        // 2 > up  3 > left  1 > down  3 > right (default)
        private void Move()
        {
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetInteger("Move", 2);
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                GetComponent<SpriteRenderer>().flipX = true;
                animator.SetInteger("Move", 3);
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                animator.SetInteger("Move", 1);
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                GetComponent<SpriteRenderer>().flipX = false;
                animator.SetInteger("Move", 3);
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
    }
}

