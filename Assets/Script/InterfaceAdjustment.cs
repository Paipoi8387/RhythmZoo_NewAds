using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAdjustment : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    float width_mul;
    float height_mul;

    void Start()
    {
        width_mul = canvas.GetComponent<RectTransform>().sizeDelta.x / 1600f;
        height_mul = canvas.GetComponent<RectTransform>().sizeDelta.y / 900f;
        
        this.transform.localScale = new Vector3(width_mul, height_mul, 1);
    }
}