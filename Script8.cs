using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script8 : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D other) {
        print(other.gameObject.name);
    }
    
    private void OnCollisionExit2D (Collision2D other) {
        print(other.gameObject.name);    
        Destroy(other.gameObject);
    }

    private void OnTriggerEnter2D (Collider2D other) {
        print(other.gameObject.name);    
        Destroy(other.gameObject);
    }
}
