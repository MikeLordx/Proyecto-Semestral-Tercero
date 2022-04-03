using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private GameObject _puzzlePanel = default;
    private Door _door = default;

    public void MoveToscene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        _door._yesButtonPressed = true;
    }

    public void CloseMenu()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _puzzlePanel.SetActive(false);
        Time.timeScale = 1;
    }
}

