using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private PlayerController playerCharacter;
    private bool isJump;

    void Awake()
    {
        playerCharacter = GetComponent<PlayerController>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
