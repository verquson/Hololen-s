using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LabelCreator : MonoBehaviour
{
    public GameObject Prefab;
    public float Scale = 0.1f;
    public string Text = "Label";
    public float FontSize = 36;
    public Color Color = Color.red;
    public Transform Position;
    public Transform Parent;

    public void CreateLabel()
    {

        GameObject Label = Instantiate(Prefab,Parent);
        Label.transform.position = Position.transform.position;
        Vector3 temp = Label.GetComponent<RectTransform>().localScale;
        temp.x = Scale;
        temp.y = Scale;
        Label.GetComponent<RectTransform>().localScale = temp;
        Label.GetComponent<TMP_Text>().text = Text;
        Label.GetComponent<TMP_Text>().fontSize = FontSize;
        Label.GetComponent<TMP_Text>().color = Color;
    }
}
