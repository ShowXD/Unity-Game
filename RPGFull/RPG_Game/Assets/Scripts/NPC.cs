using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private string _name = "Poor helpless chick";
    private string _content = "ggggg";
    public DialogSystem ds;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "SapphiArtchan" && Input.GetKey(KeyCode.Z))
        {
            ds.ShowDialog(_name, _content);
            transform.LookAt(other.transform);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ds.HideDialog();
    }
}
