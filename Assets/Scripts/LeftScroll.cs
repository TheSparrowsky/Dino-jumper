using UnityEngine;

public class LeftScroll : MonoBehaviour{

    [SerializeField]private float movementSpeed = 5f;

    void Update(){
        transform.position += transform.right * -movementSpeed * Time.deltaTime;
    }
}
