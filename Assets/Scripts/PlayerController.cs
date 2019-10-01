using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody player;
    public float speed;
    public float tilt;
    public Boundary boundary;
    private int state;

    void Start(){
        state = Random.Range(0,8);
        Debug.Log("State : " + state);
    }
    
    void FixedUpdate(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement;

        switch(state){
            case 0:
                movement = new Vector3(-speed*vertical,-speed*horizontal,0.0f);
                break;
            case 1:
                movement = new Vector3(-speed*horizontal,speed*vertical,0.0f);
                break;
            case 2:
                movement = new Vector3(speed*horizontal,-speed*vertical,0.0f);
                break;
            case 3:
                movement = new Vector3(-speed*horizontal,-speed*vertical,0.0f);
                break;
            case 4:
                movement = new Vector3(speed*vertical,speed*horizontal,0.0f);
                break;
            case 5:
                movement = new Vector3(speed*vertical,-speed*horizontal,0.0f);
                break;
            case 6:
                movement = new Vector3(-speed*vertical,speed*horizontal,0.0f);
                break;
            case 7:
                movement = new Vector3(-speed*vertical,-speed*horizontal,0.0f);
                break;
            default:
                movement = new Vector3(speed*horizontal,speed*vertical,0.0f);
                break;
        }
        
        player.velocity = movement;

        player.position = new Vector3(
            Mathf.Clamp(player.position.x,boundary.xMin,boundary.xMax),
            Mathf.Clamp(player.position.y,boundary.yMin,boundary.yMax),
            0.0f
        );

        player.rotation = Quaternion.Euler(270.0f,-tilt*player.velocity.x,0.0f);
    }
}

[System.Serializable]
public class Boundary {
    public float xMin,xMax,yMin,yMax;
}
