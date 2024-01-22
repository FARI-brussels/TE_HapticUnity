using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hapticSetup;

    public string userPromptString;
    public TMPro.TMP_InputField userPromptInput;

    void Start()
    {
        hapticSetup.SetActive(false);
    }

    void Update()
    {
        
    }

    public void StoreUserPrompt()
    {
        userPromptString = userPromptInput.text;
    }
}
