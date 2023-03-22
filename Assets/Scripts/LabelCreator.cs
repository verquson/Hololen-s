using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class LabelCreator : MonoBehaviour
{
    public GameObject LabelPrefab;
    public GameObject ExclamationMarkPrefab;
    public GameObject QuestionMarkPrefab;
    public float Scale = 0.1f;
    public string Text = "Label";
    public float FontSize = 36;
    public Color Color = Color.red;
    public Transform Position;
    public Transform Parent;
    GameObject Target;


    private void Start()
    {
        CreateLabel();
    }
    public void CreateLabel()
    {
        if (Target != null) { GameObject.Destroy(Target); }
        Target = Instantiate(LabelPrefab, Position.transform);
        Target.transform.position = Position.transform.position;
        Target.GetComponent<BoxCollider>().enabled = false;
        Vector3 temp = Target.GetComponent<RectTransform>().localScale;
        temp.x = Scale;
        temp.y = Scale;
        Target.GetComponent<RectTransform>().localScale = temp;
        Target.GetComponent<TMP_Text>().text = Text;
        Target.GetComponent<TMP_Text>().fontSize = FontSize;
        Target.GetComponent<TMP_Text>().color = Color;
    }
    public void CreateQuestionMark()
    {
        if (Target != null) { GameObject.Destroy(Target); }
        Target = Instantiate(QuestionMarkPrefab, Position.transform);
        Target.transform.position = Position.transform.position;
        Target.GetComponent<BoxCollider>().enabled = false;
        Vector3 temp = Target.GetComponent<Transform>().localScale;
        temp.x = Scale ;
        temp.y = Scale ;
        temp.z = Scale ;
        Target.GetComponent<Transform>().localScale = temp;

    }
    public void CreateExclamationMark()
    {
        if(Target != null) { GameObject.Destroy(Target); }
        Target = Instantiate(ExclamationMarkPrefab, Position.transform);
        Target.transform.position = Position.transform.position;
        Target.GetComponent<BoxCollider>().enabled = false;
        Vector3 temp = Target.GetComponent<Transform>().localScale;
        temp.x = Scale ;
        temp.y = Scale ;
        temp.z = Scale ;
        Target.GetComponent<Transform>().localScale = temp;
    }

    public void UnParent()
    {
        Target.transform.SetParent(Parent);
        Target.GetComponent<BoxCollider>().enabled = true;
        Target = null;
        CreateLabel();
    }

    public void ChangeScale(PinchSlider pinch)
    { 
        Scale = (pinch.SliderValue + 0.01f) / 3;
        Vector3 temp = Target.GetComponent<Transform>().localScale;
        temp.x = Scale;
        temp.y = Scale;
        temp.z = Scale;
        Transform t = Target.GetComponent<Transform>();
        t.localScale = temp;
        t.position = new Vector3 (t.position.x, Position.position.y + Scale, t.position.z);
    }

    public void ChangeColor(string i)
    {
        //Color = c;

        if (Target.GetComponent<TMP_Text>())
        {
            TMP_Text temp = Target.GetComponent<TMP_Text>();
            switch (i)
            {
                case "green":
                    temp.color = Color.green;
                    break;
                case "red":
                    temp.color = Color.red;
                    break;
                case "blue":
                    temp.color = Color.blue;
                    break;
                case "white":
                    temp.color = Color.white;
                    break;
                case "black":
                    temp.color = Color.black;
                    break;
                case "yellow":
                    temp.color = Color.yellow;
                    break;
                case "gray":
                    temp.color = Color.gray;
                    break;
                case "cyan":
                    temp.color = Color.cyan;
                    break;
                case "magenta":
                    temp.color = Color.magenta;
                    break;
            }
            Color = temp.color;
        }
    }

    public void ChangeText(string s)
    {
        Target.GetComponent<TMP_Text>().text = s;
    }

    public void UI()
    {
        //tähän se miten näkyy millasta ollaan luomassa ennen sen luomista
    }
}
