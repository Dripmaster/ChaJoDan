using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour {

	private Transform cloud1;
	private float cloud1Speed;
	private Transform cloud2;
	private float cloud2Speed;
	private Transform cloud3;
	private float cloud3Speed;
	private Transform cloud4;
	private float cloud4Speed;
	private Transform cloud5;
	private float cloud5Speed;
	private Transform[] mountain1;
	private float mountain1Speed;
	private Transform[] mountain2;
	private float mountain2Speed;
	private Transform[] mountain3;
	private float mountain3Speed;

	private float dt;
	// Use this for initialization
	void Start () {
		dt = Time.deltaTime;

		cloud1 = this.transform.Find ("cloud1");
		cloud1Speed = Random.Range (0.8f, 1.2f);
		cloud2 = this.transform.Find ("cloud2");
		cloud2Speed = Random.Range (0.8f, 1.2f);

		cloud3 = this.transform.Find ("cloud3");
		cloud3Speed = Random.Range (1.2f, 5.0f);
		cloud4 = this.transform.Find ("cloud4");
		cloud4Speed = Random.Range (1.2f, 5.0f);
		cloud5 = this.transform.Find ("cloud5");
		cloud5Speed = Random.Range (1.2f, 5.0f);

		mountain1 = new Transform[this.transform.Find ("mountain1").childCount];
		for (int i = 0; i < this.transform.Find ("mountain1").childCount; i++)
		{
			mountain1[i] = this.transform.Find ("mountain1").GetChild(i).transform;
		}
		mountain1Speed = 1.2f;
		mountain2 = new Transform[this.transform.Find ("mountain2").childCount];
		for (int i = 0; i < this.transform.Find ("mountain2").childCount; i++)
		{
			mountain2[i] = this.transform.Find ("mountain2").GetChild(i).transform;
		}
		mountain2Speed = 5f;
		mountain3 = new Transform[this.transform.Find ("mountain3").childCount];
		for (int i = 0; i < this.transform.Find ("mountain3").childCount; i++)
		{
			mountain3[i] = this.transform.Find ("mountain3").GetChild(i).transform;
		}
		mountain3Speed = 6.4f;

	}
	
	// Update is called once per frame
	void Update () {
		cloud1.position -= new Vector3 (cloud1Speed * dt, 0);
		cloud2.position -= new Vector3 (cloud2Speed * dt, 0);
		cloud3.position -= new Vector3 (cloud3Speed * dt, 0);
		cloud4.position -= new Vector3 (cloud4Speed * dt, 0);
		cloud5.position -= new Vector3 (cloud5Speed * dt, 0);
		if (cloud1.position.x < -6.4 - cloud1.GetComponent<SpriteRenderer> ().size.x / 2){
			float positionX = 6.4f + cloud1.GetComponent<SpriteRenderer> ().size.x / 2;
			float positionY = Random.Range (0f, 3.6f + cloud1.GetComponent<SpriteRenderer> ().size.y / 2);
			cloud1Speed = Random.Range (0.1f, 1.0f);
			cloud1.position = new Vector3 (positionX, positionY);
		}
		if (cloud2.position.x < -6.4 - cloud2.GetComponent<SpriteRenderer> ().size.x / 2){
			float positionX = 6.4f + cloud2.GetComponent<SpriteRenderer> ().size.x / 2;
			float positionY = Random.Range (0f, 3.6f + cloud2.GetComponent<SpriteRenderer> ().size.y / 2);
			cloud2Speed = Random.Range (0.1f, 1.0f);
			cloud2.position = new Vector3 (positionX, positionY);
		}
		if (cloud3.position.x < -6.4 - cloud3.GetComponent<SpriteRenderer> ().size.x / 2){
			float positionX = 6.4f + cloud3.GetComponent<SpriteRenderer> ().size.x / 2;
			float positionY = Random.Range (-1f, 2.5f + cloud3.GetComponent<SpriteRenderer> ().size.y / 2);
			cloud3Speed = Random.Range (1.0f, 3.0f);
			cloud3.position = new Vector3 (positionX, positionY);
		}
		if (cloud4.position.x < -6.4 - cloud4.GetComponent<SpriteRenderer> ().size.x / 2){
			float positionX = 6.4f + cloud4.GetComponent<SpriteRenderer> ().size.x / 2;
			float positionY = Random.Range (-1f, 2.5f + cloud4.GetComponent<SpriteRenderer> ().size.y / 2);
			cloud4Speed = Random.Range (1.0f, 3.0f);
			cloud4.position = new Vector3 (positionX, positionY);
		}
		if (cloud5.position.x < -6.4 - cloud5.GetComponent<SpriteRenderer> ().size.x / 2){
			float positionX = 6.4f + cloud5.GetComponent<SpriteRenderer> ().size.x / 2;
			float positionY = Random.Range (-1f, 2.5f + cloud5.GetComponent<SpriteRenderer> ().size.y / 2);
			cloud5Speed = Random.Range (1.0f, 3.0f);
			cloud5.position = new Vector3 (positionX, positionY);
		}

		for (int i = 0; i < this.transform.Find ("mountain1").childCount; i++)
		{
			mountain1[i].position -= new Vector3 (mountain1Speed * dt, 0);
			if (mountain1[i].position.x < -6.4 - mountain1[i].GetComponent<SpriteRenderer> ().size.x / 2) {
				float positionX = 32f;
				mountain1[i].position = new Vector3 (positionX, mountain1[i].position.y);
			}
		}
		for (int i = 0; i < this.transform.Find ("mountain2").childCount; i++)
		{
			mountain2[i].position -= new Vector3 (mountain2Speed * dt, 0);
			if (mountain2[i].position.x <= -6.4 - mountain2[i].GetComponent<SpriteRenderer> ().size.x / 2) {
				float positionX = 6.4f + mountain2[i].GetComponent<SpriteRenderer> ().size.x / 2;
				mountain2[i].position = new Vector3 (positionX, mountain2[i].position.y);
			}
		}
		for (int i = 0; i < this.transform.Find ("mountain3").childCount; i++)
		{
			mountain3[i].position -= new Vector3 (mountain3Speed * dt, 0);
			if (mountain3[i].position.x <= -12.8f) {
				mountain3 [i].position = new Vector3 (12.8f, mountain3 [i].position.y);
			}
		}

	}
}
