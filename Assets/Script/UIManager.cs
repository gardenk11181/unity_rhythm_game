using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour
{
    DataManager dataManager;

    // Use this for initialization
    void Awake()
    {
        dataManager = GetComponent<DataManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
