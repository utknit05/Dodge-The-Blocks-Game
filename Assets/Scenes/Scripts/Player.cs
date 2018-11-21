using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float speed = 15f;
    public float shiftWidth = 6.5f;

    public Text score;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        score.text = Time.timeSinceLevelLoad.ToString("0");

        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -shiftWidth, shiftWidth);

        rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D()
    {
        //Invoke("Restart", 0.5f);
        FindObjectOfType<GameManager>().EndGame();
    }

    //void Restart(){
    //    FindObjectOfType<GameManager>().EndGame();
    //}
}