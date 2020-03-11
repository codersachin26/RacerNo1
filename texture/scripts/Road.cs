using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    
    
    public GameObject Plane;
    public Renderer planeRenderer;
    public float Speed = 2f;
    public Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
       // print("ok");
       planeRenderer = Plane.GetComponent<Renderer> ();
        
    }

    // Update is called once per frame
    void Update()
    {
       offset.y += -Speed*Time.deltaTime;
       planeRenderer.material.SetTextureOffset("_MainTex",offset); 
    }
}
