using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script7 : MonoBehaviour {
    public GameObject obj;
    private GameObject instObj;
    [SerializeField] private float moveSpeed = 4f;
     
    void Start() {
        instObj = Instantiate(obj, new Vector2(0, 0), Quaternion.identity);
    }
    
    void Update() {
        float yPos = Input.GetAxis("Vertical");
        instObj.transform.Translate(Vector2.up * (moveSpeed * yPos * Time.deltaTime));
    }
}
