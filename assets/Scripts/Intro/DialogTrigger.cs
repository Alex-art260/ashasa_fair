using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    [SerializeField] GameObject dialogueAshas2;
    [SerializeField] GameObject dialogueAshas3;

    public Dialog dialog;

    public void TriggerDialog()
    {
      FindObjectOfType<DialogueManager>().StartDialog(dialog);
      dialogueAshas2.SetActive(false);
      dialogueAshas3.SetActive(true);
    }
}
