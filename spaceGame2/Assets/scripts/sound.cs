using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;

    [SerializeField] private Text volumeTextUI = null;

    private void Start()
    {
        loadValue();
    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0.0");
    }

    public void saveVolumeButton()
    {
        float volumevalue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumevalue);
        loadValue();

        Debug.Log("saved settings");
    }

    void loadValue()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}

