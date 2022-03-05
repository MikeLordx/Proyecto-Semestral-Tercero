using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] GameObject _menu;
    public void MoveToscene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void NoOption()
    {
        _menu.SetActive(false);
    }
}
