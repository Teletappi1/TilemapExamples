using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour



{
    [SerializeField] float walkSpeed;
    Vector2 displacement;
   Rigidbody2D rb;
    //float force = 0;

    //bool jumpButtonPressed = false;

    // Start is called before the first frame update
    void Start()
    {
       // transform.position = transform.position + new Vector3(0,1,0);
        //transform.Translate(new Vector3(0,1,0), Space.Self);
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetButton("Jump")) // Input.GetKey(KeyCode.Space)
        // {
        //     force += 100 * Time.deltaTime;
        //     Debug.Log(force);
        // }
        

        // if (Input.GetButtonUp("Jump")) // Input.GetKeyUp(KeyCode.Space)
        // {
        //     rb.AddForce(new Vector2(0, force));
        //     force = 0;
        // }

       // if (Input.GetButtonDown("Jump")) // Input.GetKeyUp(KeyCode.Space)
        //{
          //  jumpButtonPressed = true;
        //}

        //float xInput = Input.GetAxisRaw("Horizontal");
        //float yInput = Input.GetAxisRaw("Vertical");
        //float speed = 50;
       // Debug.Log(xInput);

        //gameObject.transform.Translate(
            //new Vector3(xInput * Time.deltaTime * speed, yInput * Time.deltaTime * speed, 0f)
        //);
    }

    void FixedUpdate()
    {
         displacement = new Vector2(
                Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")
            );
            displacement = Vector2.ClampMagnitude(displacement, 1);
             rb.MovePosition(rb.position + displacement * Time.deltaTime * walkSpeed);
            //rb.velocity = displacement * Time.deltaTime * walkSpeed;
    }

}
