using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<dialogue_manager> ().StartDialogue(dialogue);
    }

}
