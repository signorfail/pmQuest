using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "gameState")]

public class gameState : ScriptableObject
{
    [TextArea(14,10)]
    [SerializeField] string storyText;
    // Serializes gamestate with an array called nextStates
    [SerializeField] gameState[] nextStates;

    public string GetStateStory() 
    {
        return storyText;
    }

    public gameState[] GetNextStates()
    {
        return nextStates;
    }
}
