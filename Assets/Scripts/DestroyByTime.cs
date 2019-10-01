using UnityEngine;

public class DestroyByTime : MonoBehaviour{

    public GameObject gameObject;
    public float lifetime;

    void Start(){
        Destroy(gameObject,lifetime);
    }
}
