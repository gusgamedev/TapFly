using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public int score = 0;
    
    public static GameManager instance;

    private void Awake() {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    
}