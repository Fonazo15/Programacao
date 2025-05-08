using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreModify : MonoBehaviour
{
    public GameObject WorkbenchObj;
    public TextMeshProUGUI scoreTxt;
    private void Awake()
    {
        scoreTxt = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        UpdateText();
    }
    public void UpdateText()
    {
        Workbench workbenchScript = WorkbenchObj.GetComponent<Workbench>();
        if (workbenchScript.score != 0)
        {
            scoreTxt.text = "Score: " + workbenchScript.score;
        }
    }
}
