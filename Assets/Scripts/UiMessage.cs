using TMPro;
using UnityEngine;

public class UIMessage : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public TextMeshProUGUI armor;

    void Start()
    {
        messageText.text = "Find the key to open the door";
    }

    public void ShowMessage(string msg)
    {
        messageText.text = msg;
    }
    public void showArmor(string msg)
    {
       armor.text = msg;
    }
}