using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelector : MonoBehaviour
{
	public List<GameObject> models;

	[SerializeField] private int startingModel = 0;
	private int currentModel;
    // Start is called before the first frame update
    void Start()
    {
        currentModel = startingModel;

        models[currentModel].SetActive(true);
    }

    public void SwitchModel(bool isRight)
    {
    	models[currentModel].SetActive(false);
    	if(isRight)
    		currentModel = (currentModel + 1) % models.Count;
    	else
    		currentModel = (currentModel + models.Count - 1) % models.Count;
    	Debug.Log(currentModel);
    	models[currentModel].SetActive(true);


    }
}
