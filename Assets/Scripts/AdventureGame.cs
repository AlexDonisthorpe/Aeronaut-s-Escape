using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    // Start is called before the first frame update

    State currentState;

    void Start()
    {
        currentState = startingState;
        textComponent.text = currentState.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        State[] nextStates = currentState.GetNextStates();
    /*    if (Input.GetKeyDown(KeyCode.Alpha1)||Input.GetKeyDown(KeyCode.Keypad1))
        {
            currentState = nextStates[0];
        } else if (Input.GetKeyDown(KeyCode.Alpha2)||Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (nextStates.Length > 1)
            {
                currentState = nextStates[1];
            }
        } else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            if (nextStates.Length > 2)
            {
                currentState = nextStates[2];
            }
        }
    */

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index) || Input.GetKeyDown(KeyCode.Keypad1 + index))
            {
                currentState = nextStates[index];
            }
        }


        textComponent.text = currentState.GetStateStory();
    }
}
