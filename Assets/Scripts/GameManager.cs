using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void LoadScene(int buildIndex)
    {
        if (buildIndex == SceneManager.GetActiveScene().buildIndex)
            return;
        SceneManager.LoadScene(buildIndex);
    }
}
