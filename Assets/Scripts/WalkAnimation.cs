using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimation : MonoBehaviour
{
    public Animator animator;
    float horizontal, vertical,blend;
    Vector3 move;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            blend = 1;
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

        }
        if (Input.GetKey(KeyCode.A))
        {
            blend = 1;
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        if (Input.GetKey(KeyCode.S))
        {
            blend = 1;
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        if (Input.GetKey(KeyCode.D))
        {
            blend = 1;
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            blend = 0;
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            blend = 0;
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            blend = 0;
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            blend = 0;
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }

        move = new Vector3(horizontal, 0, vertical);

        animator.SetFloat("Blend", Vector3.ClampMagnitude(move, blend).magnitude, 1, Time.deltaTime * 10);
    }
}
