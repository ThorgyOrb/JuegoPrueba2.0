using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject[] objects;
    public float spawnTime = 1.0f;
    public float spawnDelay = 0.5f;
    int spawnNumber = 280;
    //create an foat array
    float[] positions = {-7.0f, -5.8f, -4.6f, -3.4f, -2.2f, -1.0f, 0.2f, 1.4f, 2.6f, 3.8f};
    void Start(){
        InvokeRepeating("SpawnCube", spawnDelay, spawnTime);
    } 
    void SpawnCube(){
        //change the x position of the object randomly using the array
        transform.position = new Vector3(positions[Random.Range(0, positions.Length)], transform.position.y, transform.position.z);
        int spawnPointIndex = Random.Range(0, objects.Length);
        Instantiate(objects[spawnPointIndex], transform.position, transform.rotation);
        //repeat 5 times and then stop
        if (spawnNumber >= 0){
            spawnNumber -= 1;
        }
        else{
            CancelInvoke("SpawnCube");
        }

    }
}
