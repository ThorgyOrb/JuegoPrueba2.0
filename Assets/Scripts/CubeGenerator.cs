using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject[] objects;
    public float spawnTime = 1.0f;
    public float spawnDelay = 0.5f;
    void Start(){
        InvokeRepeating("SpawnCube", spawnDelay, spawnTime);
    } 
    void SpawnCube(){
        int spawnPointIndex = Random.Range(0, objects.Length);
        Instantiate(objects[spawnPointIndex], transform.position, transform.rotation);
        //repeat 5 times and then stop
        if (spawnTime >= 0.6f){
            spawnTime -= 0.1f;
        }
        else{
            CancelInvoke("SpawnCube");
        }

    }
}
