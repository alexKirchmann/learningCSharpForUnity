using UnityEngine;

namespace Scripts {
    public class Script4 : MonoBehaviour {
        void OnMouseDown() {
            transform.localScale = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
        }
    }
}
