using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody ball;
    public float force; 
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ball.AddForce(Vector3.forward * force);
            
        }

    
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 colDirection = collision.contacts[0].point - transform.position;

        colDirection = -colDirection.normalized;
        if (!collision.gameObject.CompareTag("No score"))
        {
            ball.AddForce(colDirection * 1400);
        }
    }
}
