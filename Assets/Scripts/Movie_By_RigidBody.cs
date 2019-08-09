using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movie_By_RigidBody : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor  = 10f;
    private Rigidbody2D Rb;
    
    [SerializeField]
    private float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector3(horizontalInput, verticalInput, 0f) * SpeedFactor; 

        Rb.velocity = new Vector2(horizontalInput * SpeedFactor, Rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (Rb.velocity.y == 0f)
            {
                Rb.AddForce(Vector3.up * force, ForceMode2D.Impulse);
            }
        }        
    
    }
}
