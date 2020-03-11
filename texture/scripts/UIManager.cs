using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   
 public GameObject gamename;
   public GameObject playbtn;
   public GameObject quitbtn;
   public GameObject PouseRessume;
   public GameObject Highscore;
    public GameObject score;
   public Text Score;
   public Text HighScore;
   public int Scoreint;
   public int HighScoreint;

 

   public void playgame()
   {
       score.SetActive(true);
       gamename.SetActive(false);
       playbtn.SetActive(false);
       quitbtn.SetActive(false);
        Highscore.SetActive(false);
       PouseRessume.SetActive(true);

    GameManager.instance.gamestates = GameManager.Gamestates.gameplaying;
      StartCoroutine("IncreaseScore");
   }

private void Awake()
{
  
   HighScoreint = PlayerPrefs.GetInt("HighScoreint");
   
   HighScore.text = HighScoreint.ToString();
}
public void Gamesavedata()
{
   if(Scoreint>HighScoreint)
   {
      HighScoreint = Scoreint;
   }
   PlayerPrefs.SetInt("HighScoreint",HighScoreint);
}

void Start()
{
PouseRessume.SetActive(false);
score.SetActive(false);
Highscore.SetActive(true);
Scoreint = 0;
Score.text = Scoreint.ToString();

}
   public void Quitgame()
   {
   
      Application.Quit();
   }

   IEnumerator IncreaseScore()
   {
      yield return new WaitForSeconds(1f);
      while(true)
      {
        if(GameManager.instance.gamestates == GameManager.Gamestates.gameplaying)
        {
         Scoreint+=1;
         Score.text = Scoreint.ToString();
        }
         yield return new WaitForSeconds(0.2f);
      }
   }

  
   public void Rsumegame()
      {
        SceneManager.LoadScene(0);
        // GameManager.instance.gamestates = GameManager.Gamestates.gameplaying;
      }
}