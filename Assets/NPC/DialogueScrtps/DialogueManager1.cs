// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;
// using System;


// public class Dialoguemanager : MonoBehaviour
// {

//     public static Dialoguemanager Instance;


//     [Header("UI References")]
//     public Image portrait;
//     public TMP_Text actorName;
//     public TMP_Text dialogueText;

//     public bool isDialogueActive;

//     private DialogueSo CurrentDialogue;
//     private int dialogueIndex;



//     private void Awake()
//     {
//         if (Instance == null)
//             Instance = this;
//         else 
//             Destroy(gameObject);
//     }


//     public void StartDialogueSo(DialogueSo dialogueSo)
//     {
//         CurrentDialogue = dialogueSo;
//         ShowDialogue();
//     }



//     public void AdvanceDialogue()
//     {

//         if (dialogueIndex < CurrentDialogue.lines.Length)
//             ShowDialogue();
//     }



//     private void ShowDialogue()
//     {
//         DialogueLine line = CurrentDialogue.lines[dialogueIndex];
        
//         portrait.sprite = line.speaker.portrait;
//         actorName.text = line.speaker.actorName;

//         dialogueIndex.text = line.text;
    
        
//         dialogueIndex++;
//     }

//     public void StartDialogue(DialogueSo dialogue)
//     {
//         isDialogueActive = true;
//         Debug.Log("Dialogue started");
//     }

// }
