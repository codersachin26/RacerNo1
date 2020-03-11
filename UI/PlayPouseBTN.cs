using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPouseBTN : MonoBehaviour
{
    // Start is called before the first frame update
   public Sprite Pousebtn;
   public Sprite Resumebtn;

   public void PouseResumeTogele()
   {
       if(Time.timeScale!=0)
       {
           GetComponent<Image>().sprite = Pousebtn;
           Time.timeScale =0;
           return;
       }
       if(Time.timeScale==0)
       {
           GetComponent<Image>().sprite = Resumebtn;
           Time.timeScale=1;
           return;
       }
   }
}
