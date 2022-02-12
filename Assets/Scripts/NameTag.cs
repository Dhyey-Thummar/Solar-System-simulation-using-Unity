using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[ExecuteInEditMode]
public class NameTag : MonoBehaviour
{
    /*public TextMeshProUGUI text;*/
    private Transform mainCameraTransform;
    /*float dist;
    public float sensFont;*/
    private void Start()
    {
        mainCameraTransform = Camera.main.transform;
    }

    private void LateUpdate()
    {
        transform.LookAt(transform.position + mainCameraTransform.rotation * Vector3.forward, mainCameraTransform.rotation * Vector3.up);
        /*dist = (mainCameraTransform.position - text.transform.position).magnitude;
        text.fontSize = (int) (dist * sensFont);*/
    }
}
