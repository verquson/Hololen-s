using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LabelCreator : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject ExclamationMarkPrefab;
    public GameObject QuestionMarkPrefab;
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
    public void CreateQuestionMark()
    {
        GameObject QuestionMark = Instantiate(QuestionMarkPrefab, Parent);
        QuestionMark.transform.position = Position.transform.position;
        Vector3 temp = QuestionMark.GetComponent<Transform>().localScale;
        temp.x = Scale ;
        temp.y = Scale ;
        temp.z = Scale ;
        QuestionMark.GetComponent<Transform>().localScale = temp;

    }
    public void CreateExclamationMark()
    {
        GameObject ExclamationMark = Instantiate(ExclamationMarkPrefab, Parent);
        ExclamationMark.transform.position = Position.transform.position;
        Vector3 temp = ExclamationMark.GetComponent<Transform>().localScale;
        temp.x = Scale ;
        temp.y = Scale ;
        temp.z = Scale ;
        ExclamationMark.GetComponent<Transform>().localScale = temp;
    }

    public void UI()
    {
        //tähän se miten näkyy millasta ollaan luomassa ennen sen luomista
    }
}
