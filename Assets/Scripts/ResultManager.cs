using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI sentence1Text;
    [SerializeField] TextMeshProUGUI sentence2Text;
    [SerializeField] TextMeshProUGUI sentence3Text;

    [SerializeField] ResultSetence[] resultSetences;

    NameManager nameManager;
    void Start()
    {
        GameObject NameManagerObject = GameObject.Find("NameManager");
        if ( NameManagerObject != null)
        {
            nameManager = GameObject.Find("NameManager").GetComponent<NameManager>();
        }

        int level = Random.Range(0, resultSetences.Length);

        if (NameManagerObject != null)
        {
            levelText.text = nameManager.nameFromInput + "‚³‚ñ‚Í" +  resultSetences[level].type;
        }
        else
        {
            levelText.text = resultSetences[level].type;
        }
        
        sentence1Text.text = resultSetences[level].sentence1[Random.Range(0, resultSetences[level].sentence1.Length)];
        sentence2Text.text = resultSetences[level].sentence2[Random.Range(0, resultSetences[level].sentence2.Length)];
        sentence3Text.text = resultSetences[level].sentence3[Random.Range(0, resultSetences[level].sentence3.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
