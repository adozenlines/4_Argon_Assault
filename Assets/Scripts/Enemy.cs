using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;

    [SerializeField] int scorePerHit = 12;

    [SerializeField] GameObject scoreBoardCanvas;

    ScoreBoard scoreBoard;

	// Use this for initialization
	void Start () {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
        scoreBoard = scoreBoardCanvas.GetComponent<ScoreBoard>();
	}

    void OnParticleCollision(GameObject other)
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
        if (other.gameObject.tag != null)
        {
            scoreBoard.ScoreHit(scorePerHit);
        }

    }
}
