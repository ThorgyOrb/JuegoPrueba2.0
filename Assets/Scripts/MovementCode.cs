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
        //Stop the translation when the object reach -z=7
        if (transform.position.z < -7) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -7);
        }
    }
    //Detect collision with the object
    private void OnCollisionEnter(Collision collision) {
        //If the object collides with anything stop the translation
        if (collision.gameObject.tag == "Character") {
            UncleSpeed = 0;
        }
    }

}
