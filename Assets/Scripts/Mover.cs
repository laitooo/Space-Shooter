using UnityEngine;

public class Mover : MonoBehaviour{

    public Rigidbody bolt;
    public float speed;

    void Start(){
        bolt.velocity = new Vector3(0.0f,speed,0.0f);
    }

}
