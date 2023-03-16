using Microsoft.MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOpacity : MonoBehaviour
{
    public GameObject currentGameObject;
    public float alpha = 0.5f;
    private Material currentMaterial;

    // Start is called before the first frame update
    void Start()
    {
        currentGameObject = gameObject;
        currentMaterial= currentGameObject.GetComponent<Renderer>().material;
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldcolor = mat.color;
        Color oldcolor = mat.color;
        Color newcolor = new Color(oldcolor.r,oldcolor.g,oldcolor.b,alphaVal);
        mat.SetColor("_color", newcolor);
    }

    public void ChangeAlphaOnValueChange(Slider slider)
    {
        ChangeAlpha(currentMaterial, slider.Value);
    }
}
