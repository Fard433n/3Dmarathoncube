using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
  
    public Movements movements;
    // Start is called before the first frame update


    // Update is called once per frame

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacles")
        {
            movements.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
