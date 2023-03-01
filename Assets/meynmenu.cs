using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class meynmenu : MonoBehaviour
{
    [SerializeField] public GameObject MenuPANEL;
  public void PlayGame1()
  {
    
    SceneManager.LoadScene (SceneManager.GetActiveScene().name);
  }
  
  public void resume1()
  {
   
  }

  public void GoToSettings1()
  {
    SceneManager.LoadScene("Settings");
  }

  public void GoToMainMenu1()
  {
    SceneManager.LoadScene("MainMenu");
  }

  public void QuitGame1()
  {
     Application.Quit();
     Debug.Log("Quit");
  }
}
