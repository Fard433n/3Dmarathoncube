using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public Rigidbody Rb;
    // Start is called before the first frame update
    public float forwardForce = 2000f;//moving forword
    public float sidewaysforce = 500f;//moving sideways

    // Update is called once per frame
    void FixedUpdate()
    {
         Rb.AddForce(0, 0, forwardForce * Time.deltaTime);
  
        if(Input.GetKey("d"))
        {
            Rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(Rb.position.y <-1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }

}
