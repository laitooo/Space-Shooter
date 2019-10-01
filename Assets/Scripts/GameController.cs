using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour{

    public GameObject hazard;
    public Text scoreText;
    public Text reset;
    public Text gameOver;
    public int numAstroids;
    public float astroidDelay;
    public float startDelay;
    public float waveDelay;
    public Vector3 spawnValues;
    bool isPlaying;
    int score;
    

    void Start(){
        isPlaying = true;
        score = 0;
        scoreText.text = "Score : 0";
        gameOver.text = "";
        reset.text = "";
        StartCoroutine (spanWaves());
    }

    void Update(){
        if(!isPlaying){
            if(Input.GetKey("h")){
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    IEnumerator spanWaves(){
        yield return new WaitForSeconds(startDelay);
        while (isPlaying){
            for (int i = 0; i < numAstroids; i++){
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x,spawnValues.x),
                    spawnValues.y,spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard,spawnPosition,spawnRotation);
                yield return new WaitForSeconds(astroidDelay);
                if (!isPlaying){
                    break;
                }
            }
            yield return new WaitForSeconds(waveDelay);

            if (!isPlaying){
                gameOver.text = "Game Over";
                reset.text = "Press H to restart";
                break;
            }
        }
    }

    public void EndGame(){
        isPlaying = false;
    }

    public void increaseScore(int increasement){
        score += increasement;
        updateText();
    }

    void updateText(){
        scoreText.text = "Score : " + score;
    }
}
