using UnityEngine;

public class Spawner : MonoBehaviour{

    [SerializeField]private GameObject objectToSpawn;
    [SerializeField]private int howManyObstacles = 3;

    private int obstaclesCount;
    private float timer = 0.0f;

    private float[] timeToCreate = new float[] {0.15f, 2f};

    private int randomTime = 0;

    private void Start() {
        obstaclesCount = GameObject.FindGameObjectsWithTag(objectToSpawn.tag).Length;
    }

    void Update(){
        timer += Time.deltaTime;

        Debug.Log(randomTime);

        obstaclesCount = GameObject.FindGameObjectsWithTag(objectToSpawn.tag).Length;
        if(obstaclesCount < howManyObstacles && timer >= timeToCreate[randomTime]){
            if(randomTime == 0 && obstaclesCount > 2) randomTime = 1;
            randomTime = Random.Range(0, 2);
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            timer = 0f;
        }

    }
}
