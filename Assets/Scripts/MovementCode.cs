using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCode : MonoBehaviour
{
    public float UncleSpeed= 5f;
    //Get Rigidbody component from the object
    public Rigidbody rb;
    private void Start() {
        rb = GetComponent<Rigidbody>();
    }
    private void Update() {
        //Translate the object in -z direction
        transform.Translate(0, 0, -UncleSpeed * Time.deltaTime);
        


    }
}
