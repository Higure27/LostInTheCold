using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var availableStates = state.GetAvailableStates();
        if(Input.GetKeyDown(KeyCode.Q)|| Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = availableStates[0];
            textComponent.text = state.GetStateStoryText();
        }
        else if(availableStates.Length>1 && Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = availableStates[1];
            textComponent.text = state.GetStateStoryText();
        }
        else if (availableStates.Length > 2 && Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = availableStates[2];
            textComponent.text = state.GetStateStoryText();
        }
    }
}
