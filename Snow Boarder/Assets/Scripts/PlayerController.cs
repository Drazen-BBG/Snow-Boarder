using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ParticleSystem glideEffect;

    Rigidbody2D player_RB2D;

    [SerializeField] float torquePower = 2000;
    // Start is called before the first frame update
    void Start()
    {
        player_RB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player_RB2D.AddTorque(1);
        }
        */

        player_RB2D.AddTorque(-Input.GetAxis("Horizontal") * torquePower * Time.deltaTime);




        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            glideEffect.Play();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
       
            glideEffect.Stop();
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ground")
        {
            glideEffect.Play();
        }
        else if (other.tag != "Ground")
        {
            glideEffect.Play();
        }
    }
}
