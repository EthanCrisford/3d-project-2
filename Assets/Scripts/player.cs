using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    Rigidbody rbPlayer;
    Animator anim;
    bool walk;
    bool idle;


    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("walk", false);
        anim.SetBool("idle", false);

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -75 * Time.deltaTime, 0);
        }
        else
        {
            if (Input.GetKey("d"))
            {
                transform.Rotate(0, 75 * Time.deltaTime, 0);
            }
            else
            {
                anim.SetBool("Idle", true);
            }
        }

        if (Input.GetKey("space"))
        {
            rbPlayer.AddForce(transform.forward * 20f, ForceMode.Impulse);
            anim.SetBool("walk", true);
        }
    }
}
