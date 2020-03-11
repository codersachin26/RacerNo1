using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCarsGenerater : MonoBehaviour
{
    public GameObject[] ObstacleCars;
   
    
   
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("GeneraterObstacleCars",0f,4f);  
    }

    // Update is called once per frame
    void Update()
    {
         
        
    }
    private void GeneraterObstacleCars()
    {
       if(GameManager.instance.gamestates == GameManager.Gamestates.gameplaying)
       {

       float cargeneratorpoint = GameManager.instance.GameplayRelated.transform.position.y+20f;
       
        int randomnum = Random.Range(0,4);
        if(randomnum == 0)
        {
        Instantiate(ObstacleCars[Random.Range(0,ObstacleCars.Length)],new Vector3(-0.05f,cargeneratorpoint,0.5f),Quaternion.identity);
        }
        if(randomnum == 1)
        {
        Instantiate(ObstacleCars[Random.Range(0,ObstacleCars.Length)],new Vector3(5.10f,cargeneratorpoint,0.5f),Quaternion.identity);
        }
        if(randomnum == 2)
        {
        Instantiate(ObstacleCars[Random.Range(0,ObstacleCars.Length)],new Vector3(10f,cargeneratorpoint,0.5f),Quaternion.identity);
        }
        if(randomnum == 3)
        {
        Instantiate(ObstacleCars[Random.Range(0,ObstacleCars.Length)],new Vector3(5.20f,cargeneratorpoint,0.5f),Quaternion.identity);
        }
       }

    }

    
}
