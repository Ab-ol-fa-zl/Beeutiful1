using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public enum NPCState {Idle,talk}
    public NPCState currentState = NPCState.Idle;
    private NPCState DefaultState;

    public NPCTalk talk;

  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DefaultState = currentState;
        SwitschState(currentState);

    }

    private void SwitschState(NPCState newState)
    {
        currentState = newState;

        talk.enabled = newState == NPCState.talk;   
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            SwitschState(NPCState.talk);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            SwitschState(DefaultState);
    }


}
