using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveNumberEl : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;


    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("slidersound", sliderValue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("slidersound", sliderValue);
    }
}