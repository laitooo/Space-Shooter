using UnityEngine;

public class PlayerShoot : MonoBehaviour{

    public Rigidbody player;
    public GameObject shot;
    public AudioSource shootSound;
    public float shootRate = 0.5f;
    public float shootDelay = 0.0f;

    void Update(){
        if(Input.GetKey("g") && Time.time > shootDelay){
            shootDelay = Time.time + shootRate;
            Quaternion rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
            Instantiate(shot,player.position,rotation);
            shootSound.Play();
        }
    }
}
