using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJump : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 verticalForce;// variable avec la force qu'on va lui donner en haut
    public Vector3 additionalForce; // variable avec la force qu'on va rajouter à chaque fois

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity == Vector3.zero) { //Si la velocity de rb est égale à Vector3.zero
            rb.AddForce(verticalForce); // alors : lui donner une force vers le haut (rb.AddForce(force)-->verticalForce)
            verticalForce += additionalForce; // augmenter le verticalforce de additionalForce pour la prochaine fois
        }
    }
    //rb.velocity = vitesse du cube
    // chaque parties du vecteur3 = 0 ?
    // Vecteur3.zero
}