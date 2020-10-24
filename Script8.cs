using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Script8 : MonoBehaviour {

    public Text txt;
    private int i = 0;

    private void Start() {
        txt = GameObject.Find("Text").GetComponent<Text>();
    }

    private void OnCollisionEnter2D (Collision2D other) {
        print(other.gameObject.name);
    }
    
    private void OnCollisionExit2D (Collision2D other) {
        print(other.gameObject.name);    
        Destroy(other.gameObject);
    }

    private void OnTriggerEnter2D (Collider2D other) {
        i++;
        txt.text = other.gameObject.name + " " + i;
    }
}
    