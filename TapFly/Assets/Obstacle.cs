using UnityEngine;

public class Obstacle : MonoBehaviour {
   
    public float speed = 0;
    private void Start() {
        
    }

    private void Update() {

        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    
}