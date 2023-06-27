using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private Sprite[] _colors;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = _colors[UnityEngine.Random.Range(0, _colors.Length)];
    }

    void Update()
    {
        transform.Translate(0,-Speed * Time.deltaTime,  0);
    }

    private void OnBecameInvisible()
    {
        ScoreUI.score++;
        Destroy(this.gameObject);
    }
}
