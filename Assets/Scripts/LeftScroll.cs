using UnityEngine;

public class LeftScroll : MonoBehaviour{

    [SerializeField]private float movementSpeed = 5f;

    void Update(){
        transform.position += transform.right * -movementSpeed * Time.deltaTime;

        if(gameObject.tag == "Background"){
            if(transform.position.x <= -18.5f){ 
                transform.position = new Vector2(18, 0);
            }
        }


    }
}
