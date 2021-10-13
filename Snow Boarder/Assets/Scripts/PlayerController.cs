using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ParticleSystem glideEffect;

    Rigidbody2D player_RB2D;

    SurfaceEffector2D surfaceEffector2D;

    [SerializeField] float torquePower = 2000;
    [SerializeField] float boostSpeed = 30.0f;
    [SerializeField] float normalSpeed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        player_RB2D = GetComponent<Rigidbody2D>();

        surfaceEffector2D  = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = normalSpeed;
        }
        
    }

    void RotatePlayer()
    {
        player_RB2D.AddTorque(-Input.GetAxis("Horizontal") * torquePower * Time.deltaTime);
    }


}
