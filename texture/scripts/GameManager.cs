using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  

  public static GameManager instance;
  public UIManager uI;
   public GameObject GameplayRelated;
   public Gamestates gamestates;
   public GameObject ResumeGame;
   public float movespeed = 2f;
   public GameObject GameName;
   public AudioSource music;
   
    

    public void Resumegame()
   {
     
     ResumeGame.SetActive(true);
     GameName.SetActive(true);  

   }

   public enum Gamestates
   {
       none,
       mainmenu,
       gameplaying,
       paused,
       playerdied,
       gameover
   }
   
    // Start is called before the first frame update
   
   void Awake()
   {
       instance = this;
   }
    void Start()
    {
        ResumeGame.SetActive(false);
       // if(gamestates == Gamestates.none)
        //  {
        //AudioSource audio = GetComponent<AudioSource>();
        //audio.Play();
         // }

        music = GetComponent<AudioSource>();
          music.Play(0);

        
    }

    // Update is called once per frame
    void Update()
    {
        MoveGamePlayObject();
        if(gamestates == Gamestates.playerdied)
        {
           Resumegame();
           music.Stop(); 
          
        }
        
          
          



    }

    private void MoveGamePlayObject()
    {
        if(gamestates == Gamestates.gameplaying)
        {
            GameplayRelated.transform.position += Vector3.up*Time.deltaTime*movespeed;
            
        }
    }
}
