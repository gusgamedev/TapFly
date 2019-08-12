
using UnityEngine;

public class Parallax : MonoBehaviour {

    [System.Serializable]
    public class Background {
        public Transform transformBg;
        public float speedBg;
    }

    
    public Background[] backgrounds;
    public Vector2 startPosition = Vector2.zero;
    public Vector2 endPosition  = Vector2.zero;

    private void Start() {
        
    }

    private void Update() {

        foreach (Background bg in backgrounds)
        {
            bg.transformBg.Translate(Vector2.left * bg.speedBg * Time.deltaTime);

             if (bg.transformBg.localPosition.x <= endPosition.x)
                bg.transformBg.localPosition = startPosition;      
        }

       
    }

}