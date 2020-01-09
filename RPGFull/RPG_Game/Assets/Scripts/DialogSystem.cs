using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    # region variables

    [Header("Target information")]
    public Text targetName;
    public Text targetContent;
    public CanvasGroup dialogGroup;

    # endregion

    /// <summary>
    /// Set Dialog
    /// </summary>
    /// <param name="name">get NPC name</param>
    /// <param name="content">get NPC content</param>
    public void ShowDialog(string name, string content)
    {
        dialogGroup.alpha = 1;
        targetName.text = name;
        targetContent.text = content;
    }

    /// <summary>
    /// Hide Dialog
    /// </summary>
    public void HideDialog()
    {
        dialogGroup.alpha = 0;
    }
}
