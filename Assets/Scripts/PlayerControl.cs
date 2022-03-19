using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private GameManager gameManager;
    private float speed = 1.5f;
    public float turnSpeed = 40f;
    private float turn;
    private float move;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameActive == true)
        {
            Invoke("Movement", 0);
        }
        
    }

    void Movement()
    {
        //Moves the player forward and back, and they can turn too.
        turn = Input.GetAxis("Horizontal");
        move = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * move);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * turn);
        
        //Animation for walking
        anim.SetFloat("Speed", move);
    }

}
