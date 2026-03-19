using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    [Header("Pauza Sozlamalari")]
    public GameObject pausePanel; 
    private bool isPaused = false;

    // --- SETTINGS UCHUN YANGI O'ZGARUVCHI ---
    [Header("Settings Sozlamalari")]
    public GameObject settingsPanel; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void NewGame()
    {
        PersistentAudioManager.PlaySound(); // Ovoz qo'shildi
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene"); 
        Debug.Log("Yangi o'yin boshlandi");
    }

    public void Exit()
    {
        PersistentAudioManager.PlaySound(); // Ovoz qo'shildi
        Application.Quit();
        Debug.Log("O'yindan chiqildi");
    }

    public void Pause()
    {
        if (pausePanel != null)
        {
            PersistentAudioManager.PlaySound(); // Ovoz qo'shildi
            pausePanel.SetActive(true); 
            Time.timeScale = 0f;        
            isPaused = true;
            Debug.Log("O'yin to'xtatildi (Pauza)");
        }
    }

    public void Resume()
    {
        if (pausePanel != null)
        {
            PersistentAudioManager.PlaySound(); // Ovoz qo'shildi
            pausePanel.SetActive(false); 
            Time.timeScale = 1f;         
            isPaused = false;
            Debug.Log("O'yin davom ettirilmoqda");
        }
    }

    public void Quit()
    {
        PersistentAudioManager.PlaySound(); // Ovoz qo'shildi
        Debug.Log("O'yindan chiqilmoqda...");
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void GoToMainMenu()
    {
        PersistentAudioManager.PlaySound(); // Ovoz qo'shildi
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); 
    }

    // --- SETTINGS UCHUN YANGI FUNKSIYALAR ---

    public void OpenSettings()
    {
        if (settingsPanel != null)
        {
            PersistentAudioManager.PlaySound(); // Ovoz qo'shildi
            settingsPanel.SetActive(true);
            Debug.Log("Settings paneli ochildi");
        }
    }

    public void CloseSettings()
    {
        if (settingsPanel != null)
        {
            PersistentAudioManager.PlaySound(); // Ovoz qo'shildi
            settingsPanel.SetActive(false);
            Debug.Log("Settings paneli yopildi");
        }
    }
}