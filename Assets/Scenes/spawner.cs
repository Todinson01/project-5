using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Boyagi yaratgan ko'k Prefabni shu yerga qo'yamiz
    public float spawnRate = 2f;      // Har 2 soniyada bitta to'siq chiqadi
    private float timer = 0f;

    void Update()
    {
        // Vaqtni hisoblab borish
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            // Vaqt kelganda yangi to'siq yaratish
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        // To'siqni Spawner turgan joyda (o'ng tomonda) yaratish
        Instantiate(obstaclePrefab, transform.position, transform.rotation);
    }
}