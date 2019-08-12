using UnityEngine;

public class SpawnObstacles : MonoBehaviour {
    public float timeBtwSpawn = 2f;
    public GameObject obstacle;
    
    private void Start() {
        
        InvokeRepeating("Spawn", timeBtwSpawn, timeBtwSpawn);
        
    }

    void Spawn() {

        Vector2 pos = new Vector2(transform.position.x, Random.Range(0,1));
        GameObject clone = (GameObject)Instantiate(obstacle, pos, Quaternion.identity);
        clone.transform.parent = transform;
    }

    public void StopSpawn() {
        
        CancelInvoke("Spawn");

    }



}