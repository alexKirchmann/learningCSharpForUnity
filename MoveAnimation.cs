using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements.Experimental;

public class MoveAnimation : MonoBehaviour {

    public AnimationCurve Easing;
    
    private Vector2 startPosition;
    private Vector2 targetPosition;
    private float timeFromStart = 0;
    
    void Start() {
        transform.DOMoveX(5, 1);
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

