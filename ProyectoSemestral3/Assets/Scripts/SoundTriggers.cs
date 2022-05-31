using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTriggers : MonoBehaviour
{
    [SerializeField] private AudioSource _audio = default;
    [SerializeField] private GameObject _tutorialCanva = default;

    private void OnTriggerEnter(Collider other)
    {
        _audio.Play();
        _tutorialCanva.SetActive(true);
        StartCoroutine(FinishedPlaying());
    }

    IEnumerator FinishedPlaying()
    {
        yield return new WaitForSeconds(10);
        gameObject.SetActive(false);
        _tutorialCanva.SetActive(false);
    }
}
