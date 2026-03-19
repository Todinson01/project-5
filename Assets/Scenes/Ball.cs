using UnityEngine;

public class Ball : MonoBehaviour
{
    public float jumpForce = 8f;
    public ScoreManager scoreManager; // Buni Inspector-dan ulang!
    private Rigidbody2D rb;
    private bool isDead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("oblicast") || collision.gameObject.CompareTag("Ground"))
        {
            if (!isDead)
            {
                isDead = true;
                if (scoreManager != null) scoreManager.GameOver();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ScoreZone") && !isDead)
        {
            if (scoreManager != null) scoreManager.AddScore(1);
        }
    }
}