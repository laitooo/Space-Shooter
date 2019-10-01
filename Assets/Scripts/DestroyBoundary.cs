using UnityEngine;

public class DestroyBoundary : MonoBehaviour{

    void OnTriggerExit(Collider other){
        Destroy(other.gameObject);
    }
}
