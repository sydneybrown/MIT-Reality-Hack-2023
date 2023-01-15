using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelWalk : MonoBehaviour
{
	GameObject model;
	[SerializeField] Transform target;
	[SerializeField] ModelSelector select;
	[SerializeField] float speed = 0.000001f;

    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject playButton;

    private bool paused = false;
	
    // Start is called before the first frame update
    void Start()
    {
    	model = select.GetSelection();
    	model.SetActive(true);
        pauseButton.SetActive(true);
        playButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    	
    	if(model.transform.position.z < target.position.z && !paused)
    		model.transform.position += new Vector3(0,0,Time.deltaTime * speed);
    	else
    		; //possibly rotate

        
    }

    public void Pause()
    {
        paused = true;
        pauseButton.SetActive(false);
        playButton.SetActive(true);
    }

    public void Play()
    {
        paused = false;
        pauseButton.SetActive(true);
        playButton.SetActive(false);
    }



}
