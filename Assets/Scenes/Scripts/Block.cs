using UnityEngine;

public class Block : MonoBehaviour {

    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    void Update () {
        if(transform.position.y < -4.5f){
            Destroy(gameObject);
        }	
	}
}
