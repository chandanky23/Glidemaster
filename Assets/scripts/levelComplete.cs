using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
   public void loadNextLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
