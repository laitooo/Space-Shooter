using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour{

    public Rigidbody astroid;
    float randomValue;

    void Start(){
        randomValue = Random.value;
    }

    void FixedUpdate(){
        astroid.angularVelocity = new Vector3(0.0f,0.0f,5*randomValue);
    }
}
