using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Collision!"); 
        if (collision.gameObject.CompareTag("Player")) 
        {
            this.gameObject.SetActive(false); 
        }
    }
}
