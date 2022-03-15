using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private float speed = 1.5f;
    public float turnSpeed = 40f;
    private float turn;
    private float move;
    Animator anim;
  
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Movement", 0);
    }

    void Movement()
    {
        //Moves the player forward and back, and they can turn too.
        turn = Input.GetAxis("Horizontal");
        move = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * move);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * turn);

        //Animation for walking
      //  float moveForward = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", move);
    }
    


}
