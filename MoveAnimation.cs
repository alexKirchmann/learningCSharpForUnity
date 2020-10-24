using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour {
    private Vector2 targetPosition;
    
    void Start() {
        targetPosition = (Vector2) transform.position + Vector2.right * 10;
    }

    void Update() {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 10);
    }
}
