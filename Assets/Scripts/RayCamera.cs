using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCamera : MonoBehaviour
{
    private float lookspeed = 1f;
    
    void LookOnCursor()
    {       
        Plane playerPlane = new Plane(Vector3.up, transform.position); 		
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition); 		
        float hitdist = 0;  		
        if (playerPlane.Raycast (ray, out hitdist)) 
        { 			Vector3 targetPoint = ray.GetPoint (hitdist);  			
            Quaternion targetRotation = Quaternion.LookRotation (targetPoint - transform.position);  	
            transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, lookspeed * Time.deltaTime); 		} 	}
        
        void Update()
        {
         LookOnCursor();
        }

        //// Update is called once per frame
        //void Update()
        //{
        //    Ray ray = new Ray(transform.position, new Vector3(90, 0, 0));
        //    Debug.DrawRay(transform.position, transform.forward * 100, Color.red);

        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        ray.direction = new Vector3(0,0,0);
        //        Debug.Log(Input.mousePosition);
        //    }
        //    Physics.Raycast(ray);
        //}

        //public Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //public RaycastHit hit;
        //void Awake()
        //{
        //    if (Physics.Raycast(ray, out hit, 100,/*слой с бочкой*/))
        //        print(hit.point);
        //}
    }
