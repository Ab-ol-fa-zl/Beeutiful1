using UnityEngine;

[CreateAssetMenu(fileName = "DialogueSo", menuName = "Dialogue/DialogueNode")]
public class DialogueSo: ScriptableObject
{
    public DialogueLine[] lines;

}

    [System.Serializable]
    public class DialogueLine
    {
        public ActorSO speaker;
        [TextArea(3,5)]public string text;
    
    // internal string lineText;
}

