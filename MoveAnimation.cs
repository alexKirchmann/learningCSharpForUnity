using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class MoveAnimation : MonoBehaviour {
    private Vector2 startPosition;
    private Vector2 targetPosition;
    private float timeFromStart = 0;
    
    void Start() {
        startPosition = transform.position;
        targetPosition = (Vector2) transform.position + Vector2.right * 10;
    }

    void Update() {
        transform.position = Vector2.Lerp(transform.position, targetPosition, EasingSquared(timeFromStart/3));
        timeFromStart += Time.deltaTime;
    }

    float EasingLinear(float x) {
        return x;
    }

    float EasingSquared(float x) {
        return x * x;
    }

    float EasingInverseSquared(float x) {
        return 1 - (1 - x) * (1 - x);
    }

    float EasingSmoothedSquared(float x) {
        return x < 0.5 ? x * x * 2 : (1 - (1 - x) * (1 - x) * 2);
    }

    float EasingCube(float x) {
        return x * x * x;
    }
    
    //easings.com
}

