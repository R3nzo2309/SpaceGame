using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeValue : MonoBehaviour
{
    [SerializeField] private Slider musicVolumeSlider = null;

    [SerializeField] private Text musicVolumeTextUI = null;
    public AudioSource audioSource;

    private void Start()
    {
        LoadValue();
    }

    public void VolumeSlider(float volume)
    {
        musicVolumeTextUI.text = volume.ToString("0.0");
    }

    public void SaveVolumeButton()
    {
        float volumevalue = musicVolumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumevalue);
        LoadValue();

        Debug.Log("saved settings");
    }

    void LoadValue()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        musicVolumeSlider.value = volumeValue;
        audioSource.volume = volumeValue;
    }
}
