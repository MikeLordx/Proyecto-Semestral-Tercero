using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTriggers : MonoBehaviour
{
    [SerializeField] private GameObject _background = default;
    [SerializeField] private GameObject _title = default;
    private Text _playText = default;
    private Text _settingsText = default;

    private void Start()
    {
        _playText = GetComponent<Text>();
        _settingsText = GetComponent<Text>();
    }
    public void PlayHoverEnter()
    {
        _playText.color = Color.red;
        _title.GetComponent<Image>().color = Color.red;
        _background.GetComponent<Image>().color = Color.red;
    }
    public void PlayHoverExit()
    {
        _playText.color = Color.white;
        _title.GetComponent<Image>().color = Color.white;
        _background.GetComponent <Image>().color = Color.white;
    }

    public void SettingsHoverEnter()
    {
        _settingsText.color = Color.blue;
        _title.GetComponent<Image>().color = Color.blue;
        _background.GetComponent<Image>().color = Color.blue;
    }

    public void SettingsHoverExit()
    {
        _settingsText.color = Color.white;
                _title.GetComponent<Image>().color = Color.white;
        _background.GetComponent <Image>().color = Color.white;
    }    
}
