using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCar : MonoBehaviour
{
   public float movespeed=0f;
   public float  Zrotation=0f;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       if(movespeed >0f)
       {
       transform.Translate(transform.up*Time.deltaTime*movespeed);
       }
    }  


 void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "OtherCar")
        {
            Destroy (other.gameObject);
            
            
           
        }
    }

     
}
