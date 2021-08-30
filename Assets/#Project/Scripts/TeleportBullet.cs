using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TeleportBullet : MonoBehaviour
{
    public GameObject player; //public pour quelle soit utilisable dans une autre classe
    void OnCollisionEnter(Collision collision) {
        if (!collision.collider.CompareTag("Bounce")) {
            Destroy(gameObject); //gameObject donne le gameObject auquel appartient le script
        }
        //Debug.Log("Point de contact : " + collision.GetContact(0).point);
        
        if (collision.collider.CompareTag("Teleport")) { //si le collider contre lequel on s'est collisioné à le tag "Teleport", le joueur se teleporte sur la plateforme
            player.transform.position = collision.GetContact(0).point;
        }
    }
}
