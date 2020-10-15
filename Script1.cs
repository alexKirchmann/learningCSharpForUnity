using UnityEngine;

namespace Scripts
{
    public class Script1 : MonoBehaviour
    {
        public int i = 0;
        private int n = 0;

        void Awaken()
        { 
            Debug.Log("Awaken: " + n);
        }

        void Start()
        {
        
        }

        void Update()
        {
            //Debug.Log("Update: " + i);
        }

        void FixedUpdate()
        {
        
        }
    }
}
