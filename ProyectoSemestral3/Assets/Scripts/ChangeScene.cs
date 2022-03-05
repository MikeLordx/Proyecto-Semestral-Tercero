using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] GameObject _menu = default;
    public void MoveToscene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void NoOption()
    {
        _menu.SetActive(false);
    }
}
