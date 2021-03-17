using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour{

    [SerializeField]private Text pointText;
    [SerializeField]private Text summaryText;
    [SerializeField]private GameObject restartButton;

    private int points = 0;
    private float timer = 0f;

    public bool isStopped = false;

    // Start is called before the first frame update
    void Start(){
        summaryText.enabled = false;
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update(){

        if(Time.timeScale == 0 && !isStopped){
            summaryText.text += "Score: " + points.ToString();
            summaryText.enabled = true;
            restartButton.SetActive(true);
            isStopped = true;
        }

        timer += Time.deltaTime;
        if(timer >= 1){
            points += 1;
            timer = 0;
        }
        pointText.text = points.ToString();

    }
}
