using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private GameObject _puzzlePanel = default;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void MoveToscene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void CloseMenu()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _puzzlePanel.SetActive(false);
        Time.timeScale = 1;
    }
}

