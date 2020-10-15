using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Scripts {
    public class Script6 : MonoBehaviour {
        public GameObject obj;

        private void Start() {
            Invoke("Inst", 2f);
        }

        void Update() {
            if (Input.GetKey(KeyCode.F))
                StartCoroutine(instObj());
        }

        void Inst() {
            Instantiate(obj, new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f)), Quaternion.identity);
        }

        IEnumerator instObj() {
            while (true) {
                Instantiate(obj, new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f)), Quaternion.identity);
                yield return new WaitForSeconds(2.5f);
            }
        }
    }
}
