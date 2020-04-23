using UnityEngine;
using UnityEngine.SceneManagement;
public class manageGame : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelayed = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame ()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelayed);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
