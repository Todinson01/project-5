using UnityEngine;

public class PersistentAudioManager : MonoBehaviour
{
    public static PersistentAudioManager instance;
    private AudioSource audioSource;

    void Awake()
    {
        // Singleton mantiqi: Faqat bitta nusxa qoldiramiz
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); // Sahnadan sahnaga olib o'tish
        audioSource = GetComponent<AudioSource>();
    }

    // Bu funksiyani boshqa skriptlardan static holda chaqiramiz
    public static void PlaySound()
    {
        if (instance != null && instance.audioSource != null && instance.audioSource.clip != null)
        {
            instance.audioSource.PlayOneShot(instance.audioSource.clip);
        }
    }
}