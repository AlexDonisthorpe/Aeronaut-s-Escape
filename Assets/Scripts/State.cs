using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    [TextArea(10, 14)][SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory() => storyText;
    public State[] GetNextStates() => nextStates;
}

