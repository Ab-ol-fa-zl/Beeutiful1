using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public Animator interactAnim;
    public DialogueSo DialogueSo;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    private void OnEnable()
    {
        rb.linearVelocity = Vector2.zero;
        anim.Play("Idle");
        interactAnim.Play("Open");
    }

    private void OnDisable()
    {
        interactAnim.Play("Close");
    }

    private void Update()
    {
        if(Input.GetButtonDown("Interact"))
        {
            if(DialogueManager.Instance.isDialogueActive)
                DialogueManager.Instance.AdvanceDialogue();
            else
                DialogueManager.Instance.StartDialogue(DialogueSo);
                
        
        }
    }



}
