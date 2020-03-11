using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarMovement : MonoBehaviour
{
    
    public bool carchanginglane;
    public bool Iscarleft;
    public float moveSpeed=2f;
    public float xpos=5f;
    public Road road;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            carchanginglane = true;
            Iscarleft = true;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            carchanginglane = true;
            Iscarleft = false;
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp(KeyCode.RightArrow))
        {
            carchanginglane = false;
        }
        ChangeCarLane();
    }

private void ChangeCarLane()
{
    if(carchanginglane)
    {
        if(Iscarleft)
        {
            if(xpos>-0.28f)
            {
                xpos-=Time.deltaTime*moveSpeed;
            }
        }
        else
        if(!Iscarleft)
        {
            if(xpos<7f)
            {
                xpos+= Time.deltaTime*moveSpeed;
            }
        }
        this.transform.position = new Vector3(xpos,transform.position.y,transform.position.z);
    }
    
}
  


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "OtherCar")
        {
            Destroy (other.gameObject);
            road.Speed = 0f;
            this.gameObject.SetActive(false);
        }
    }
}
