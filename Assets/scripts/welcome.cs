using UnityEngine;
using UnityEngine.SceneManagement;

public class welcome : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
