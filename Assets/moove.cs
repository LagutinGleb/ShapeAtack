using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.forward, ForceMode.VelocityChange); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
