using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    [SerializeField]private UIManager uIManager;

    public void gameExit(){
        Application.Quit();
    }

    public void gameRestart(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void playButtonSound(){
        GetComponent<AudioSource>().Play();
    }
}
