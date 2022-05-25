using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveNumberMusic : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;


    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("slidermusic", sliderValue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("slidermusic", sliderValue);
    }
}