using UnityEngine;

namespace Scripts {
    public class Script2 : MonoBehaviour {
        public Light myLight;

        public GameObject myObj;
    
        private int numEnemies = 10;
    
        // Start is called before the first frame update
        void Start() {
            myLight = GetComponent<Light>();
        
            for (int i = 1; i < numEnemies + 1; i++) {
                Debug.Log("Created " + i + " enemies");
            }
        }
 
        // Update is called once per frame
        void Update() {
            if (Input.GetKeyUp(KeyCode.Space)) {
                myLight.enabled = !myLight.enabled;
            }

            if (Input.GetKeyUp(KeyCode.A)) {
                myObj.SetActive(false);
            }

            if (Input.GetKeyUp(KeyCode.S)) {
                Destroy(myObj);
            }

            if (Input.GetKeyUp(KeyCode.R))
                myObj.GetComponent<Renderer>().material.color = Color.red;

            switch (Input.GetKeyUp(KeyCode.B)) {
                case true: {
                    myObj.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                }
            }

            if (Input.GetKeyDown(KeyCode.G))
                myObj.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
