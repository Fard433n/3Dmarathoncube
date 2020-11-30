
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    bool gameEnded = false;
    // Update is called once per frame
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void Completelevel ()
    {
        completeLevelUI.SetActive(true);
    }
   public void Endgame()
    {
       if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("game over");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
