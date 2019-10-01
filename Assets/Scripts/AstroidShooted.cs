using UnityEngine;

public class AstroidShooted : MonoBehaviour
{
    
    public GameObject astroid;
    public GameObject small_explotion;
    public GameObject big_explotion;
    GameController gameController;
    public int scoreIncreasement;

    void Start(){
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Shot1"){
            Instantiate(small_explotion,astroid.transform.position,astroid.transform.rotation);
            Destroy(other.gameObject);
            Destroy(astroid);
            gameController.increaseScore(scoreIncreasement);
        }

        if (other.gameObject.tag == "Player"){
            Instantiate(big_explotion,astroid.transform.position,astroid.transform.rotation);
            Destroy(other.gameObject);
            Destroy(astroid);
            Debug.Log("Game Over");
            gameController.EndGame();
        }
    }
}
