using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetInteger("Direction", 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetInteger("Direction", 1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetInteger("Direction", 2);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetInteger("Direction", 3);
        }
    }
}
