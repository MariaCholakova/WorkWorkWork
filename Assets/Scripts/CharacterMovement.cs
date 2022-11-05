using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 5f;
    private CharacterController controller;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        controller.Move(movement * Time.deltaTime * speed);


        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), rotationSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), rotationSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), rotationSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetAxis("Vertical") < 0) 
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), rotationSpeed * Time.deltaTime);
            animator.SetBool("isWalking", true);
        }

        if (Input.GetAxis("Vertical") == 0f && Input.GetAxis("Horizontal") == 0f) 
        {
            animator.SetBool("isWalking", false);
        }
    }
}
