using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class NameUI : MonoBehaviour
{
    public TextMeshProUGUI PlanetName;
    [SerializeField]CelestialBody celestialBody;

    private void Awake()
    {
        PlanetName.text = celestialBody.name;
    }

}
