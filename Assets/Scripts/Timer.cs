using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float _timer = 0;
    
    void Update()
    {
        _timer += Time.deltaTime;
        timerText.text = _timer.ToString("f2");
    }
}
