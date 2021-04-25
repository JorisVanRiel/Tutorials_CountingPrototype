using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    public string boxName;

    private int Count = 0;

    private void Start()
    {
        Count = 0;
        this.UpdateText();
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        UpdateText();
    }

    private void UpdateText()
    {
        CounterText.text = $"{this.boxName}: {this.Count}";
    }

}
