using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour {
    private Vector2 startPosition;
    private Vector2 targetPosition;
    private float timeFromStart = 0;
    
    void Start() {
        startPosition = transform.position;
        targetPosition = (Vector2) transform.position + Vector2.right * 10;
    }

    void Update() {
        transform.position = Vector2.Lerp(transform.position, targetPosition, timeFromStart/3);
        timeFromStart += Time.deltaTime;
    }
}

