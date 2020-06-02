using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pmAdventure : MonoBehaviour
{
    // SerializeField makes available the component in Unity
    [SerializeField] Text textComponent;
    [SerializeField] gameState startingState;

    // The variable state gets state information from gameState.cs
    gameState state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        manageState();
    }

    private void manageState()
    {
        var nextStates = state.GetNextStates();
        for (int i = 0; i < nextStates.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }

        textComponent.text = state.GetStateStory();
    }
}
