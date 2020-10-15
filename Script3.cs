using UnityEngine;

namespace Scripts
{
    public class Script3 : MonoBehaviour
    {

        public GameObject gameObject;
        public float moveRange = 5f, moveSpeed = 3f, turnSpeed = 40f;
    
    
    
        void Update()
        {
            /*float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * moveRange;
        float yPos = v * moveRange;
        gameObject.transform.position = new Vector2 (xPos, yPos);*/

            if (Input.GetKey(KeyCode.UpArrow))
                gameObject.transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    
            if (Input.GetKey(KeyCode.DownArrow))
                gameObject.transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);
    
            if (Input.GetKey(KeyCode.LeftArrow))
                gameObject.transform.Rotate(Vector2.up, -turnSpeed * Time.deltaTime);
    
            if (Input.GetKey(KeyCode.RightArrow))
                gameObject.transform.Rotate(Vector2.up, turnSpeed * Time.deltaTime);
        }
    }
}