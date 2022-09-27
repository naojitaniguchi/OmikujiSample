using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameManager : MonoBehaviour
{
    [SerializeField] TMP_InputField nameText;
    [SerializeField] TMP_InputField bdText;

    public string nameFromInput;
    public string bdFromInput;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputName()
    {
        nameFromInput = nameText.text;
        Debug.Log(nameFromInput);
    }
    public void InputBD()
    {
        bdFromInput = bdText.text;
        Debug.Log(bdFromInput);
    }

}
