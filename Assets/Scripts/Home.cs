using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    [SerializeField] private GameObject storyStartPanel;
    [SerializeField] private GameObject storyIncompletePanel;
    [SerializeField] private GameObject storyCompletePanel;

    public void NewGame(int lastScene) {
        if (GameManager.Instance.HasNone() && lastScene == 0)
        {
            storyStartPanel.SetActive(true);
        }
    }

    public void DoorInteract()
    {
        if (GameManager.Instance.HasAll())
        {
            storyCompletePanel.SetActive(true);
        }
        else
        {
            storyIncompletePanel.SetActive(true);
        }
    }
}
