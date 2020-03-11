using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RacerCar : MonoBehaviour
{
    
    public bool carchanginglane;
    public bool RacerCarRotation;
    public bool Iscarleft;
    public float moveSpeed=3f;
    public float xpos=5.10f;
    public Road road;
    public float Zrotation =0f;
    public UIManager uI;
    

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(xpos,transform.position.y,transform.position.z);
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            carchanginglane = true;
            Iscarleft = true;
            RacerCarRotation =true ;
           
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            carchanginglane = true;
            Iscarleft = false;
            RacerCarRotation = true;
            
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp(KeyCode.RightArrow))
        {
            carchanginglane = false;
             RacerCarRotation = false;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 mousepos = Input.mousePosition;
            if(mousepos.x<Screen.width/2f&&GameManager.instance.gamestates == GameManager.Gamestates.gameplaying)
            {
              carchanginglane = true;
               Iscarleft = true;
               RacerCarRotation =true ;  
            }
            if(mousepos.x>Screen.width/2f&&GameManager.instance.gamestates == GameManager.Gamestates.gameplaying)
            {
                  carchanginglane = true;
                 Iscarleft = false;
                  RacerCarRotation = true;
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
             carchanginglane = false;
             RacerCarRotation = false;  
        }
        ChangeCarLane();
    }

private void ChangeCarLane()
{
    if(carchanginglane)
    {
        if(Iscarleft)
        {
            if(xpos>0.20f)
            {
                xpos-=Time.deltaTime*moveSpeed*3f;
            }
            if(Zrotation<=11f)
            {
                Zrotation += Time.deltaTime*moveSpeed*8f;
            }
        }
        else
        if(!Iscarleft)
        {
            if(xpos<10f)
            {
                xpos+= Time.deltaTime*moveSpeed*3f;
            }
            if(Zrotation>=-11f)
            {
                Zrotation -= Time.deltaTime*moveSpeed*8f;
            }
                
        }
            
    
        this.transform.position = new Vector3(xpos,transform.position.y,transform.position.z);
        this.transform.rotation = Quaternion.Euler(0f,0f,Zrotation);
    }
    if(!RacerCarRotation)
    {
        Zrotation = Mathf.Lerp(Zrotation,0f,Time.deltaTime*moveSpeed*5f);
    }
                this.transform.position = new Vector3(xpos,transform.position.y,transform.position.z);
                 this.transform.rotation = Quaternion.Euler(0f,0f,Zrotation);
    if(!RacerCarRotation)
               {
                   this.transform.rotation = Quaternion.Euler(0f,0f,0f);
               }
    
}
  


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "OtherCar")
        {
            Destroy (other.gameObject);
            road.Speed = 0f;
            GameManager.instance.gamestates = GameManager.Gamestates.playerdied;
            uI.Gamesavedata();
            this.gameObject.SetActive(false);
        }
    }

    


}
