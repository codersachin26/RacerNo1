using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCarMover : MonoBehaviour
{
    // Start is called before the first frame update


   


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "OtherCar")
        {
           ObstacleCar obsCar = other.GetComponent<ObstacleCar>();
           GiveRandomspeed(obsCar);
        }
    }

    private void GiveRandomspeed(ObstacleCar _obsCar)
    {
      float randomspeed = Random.Range(3f,8f);
        if(_obsCar.movespeed == 0f)
        {
            _obsCar.movespeed = randomspeed;
        }
    }
}
