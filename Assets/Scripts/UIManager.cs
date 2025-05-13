using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController PlayerController;
    public TMP_Text healthText;
    public TMP_Text livesText;

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + PlayerController.health;
        livesText.text = "Lives: " + PlayerController.lives;
    }
}
