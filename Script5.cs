using UnityEngine;

namespace Scripts {
    public class Script5 : MonoBehaviour {
        public GameObject[] objects;
        private GameObject instObj;
        
        void Start() {
            int rnd = Random.Range(0, objects.Length - 1);

            for (int i = 0; i < objects.Length; i++) {
                instObj = Instantiate(objects[rnd], objects[rnd].transform.position, Quaternion.identity);
                instObj.transform.localScale = new Vector2(0.25f, 0.25f);
            }
        }
    }
}
