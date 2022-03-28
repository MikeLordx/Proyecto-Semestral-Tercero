using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    private bool _isPaused = default;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _isPaused = TogglePause();
            if (_isPaused)
            {
                _pauseMenu.SetActive(true);
            }
            else
            {
                _pauseMenu.SetActive(false);
            }
        }
    }

    bool TogglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}
