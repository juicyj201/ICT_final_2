using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float speed = 5f;

    private Vector2 playerVec;
    private Animator animator;

    private bool attack;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerVec.x = Input.GetAxisRaw("Horizontal");
        playerVec.y = Input.GetAxisRaw("Vertical");

        //mooooov
        if (playerVec.x != 0 && Input.GetButton("Fire3") == false)
        {
            //right and left
            rigid.MovePosition(rigid.position + playerVec * speed * Time.deltaTime);
            animator.SetFloat("HorizontalMovement", playerVec.x);
            animator.SetFloat("VerticalMovement", 0);
            animator.SetBool("Moving", true);
        }
        else {
            animator.SetFloat("HorizontalMovement", 0);
        }
        if (playerVec.y != 0 && Input.GetButton("Fire3") == false)
        {
            //up and down
            rigid.MovePosition(rigid.position + playerVec * speed * Time.deltaTime);
            animator.SetFloat("HorizontalMovement", 0);
            animator.SetFloat("VerticalMovement", playerVec.y);
            animator.SetBool("Moving", true);
        }
        else {
            animator.SetFloat("VerticalMovement", 0);
        }

        //attacccc
        if (Input.GetButton("Fire3") && playerVec.x != 0) {
            //attack horizontal
            animator.SetFloat("HorizontalAttack", playerVec.x);
            animator.SetFloat("HorizontalMovement", 0);
            animator.SetBool("Moving", true);
        }
        else if(Input.GetButtonUp("Fire3") && playerVec.x != 0)
        {
            animator.SetFloat("HorizontalAttack", 0);
            animator.SetFloat("VerticalAttack", 0);
            animator.SetBool("Moving", true);
        }

        if (Input.GetButton("Fire3") && playerVec.y != 0) {
            //attack vertical
            animator.SetFloat("HorizontalAttack", 0);
            animator.SetFloat("VerticalAttack", playerVec.y);
            animator.SetBool("Moving", true);
        }
        else if(Input.GetButtonUp("Fire3") && playerVec.y != 0)
        {
            animator.SetFloat("HorizontalAttack", 0);
            animator.SetFloat("VerticalAttack", 0);
            animator.SetBool("Moving", true);
        }

        /**
        if (Input.GetButton("Fire3")) {
            speed += 10;
        }
        **/
    }
}
