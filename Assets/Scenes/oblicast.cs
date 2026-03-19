using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name == "Ball")
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f; 
        }
    }
}