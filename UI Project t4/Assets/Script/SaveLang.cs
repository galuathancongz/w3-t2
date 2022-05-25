using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveLang : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Dropdown dropdown;
    public int dropdownValue;


    // Start is called before the first frame update
    void Start()
    {
        dropdown.value = PlayerPrefs.GetInt("droplang", dropdownValue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeDropdown(int value)
    {
        dropdownValue = value;
        PlayerPrefs.SetInt("droplang", dropdownValue);
    }
}
