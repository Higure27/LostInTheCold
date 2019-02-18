using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows to create "State" scriptable object from the menu 
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //Text area size 10 lines and goes up to 14 before user needs to scroll in the inspector
    [TextArea(10,14)][SerializeField] string StoryText;
    //Story options the player can choose  from
    [SerializeField] State[] availableStates;

    public string GetStateStoryText()
    {
        return StoryText;
    }

    public State[] GetAvailableStates()
    {
        return availableStates;
    }
}
