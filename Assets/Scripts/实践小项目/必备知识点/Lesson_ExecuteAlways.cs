using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteAlways]
public class Lesson_ExecuteAlways : MonoBehaviour {
    private void Awake() {
        Debug.Log("Awake");
    }
    private void OnEnable() {
        Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Start");
    }
    private void FixedUpdate() {
        Debug.Log("FixedUpdate");
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("Update");
    }
    private void LateUpdate() {
        Debug.Log("LateUpdate");
    }
    private void OnGUI() {
        Debug.Log("OnGUI");
    }
    private void OnDisable() {
        Debug.Log("OnDisable");
    }
    private void OnDestroy() {
        Debug.Log("OnDestroy");
    }
}
