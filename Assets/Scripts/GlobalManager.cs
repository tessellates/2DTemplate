using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Template2D
{
    /// <summary>
    /// Class <c>GlobalManager</c> is the main controller for the program. It is a singleton class.
    /// </summary>
    public class GlobalManager : MonoBehaviour
    {
        // Singleton instance
        private static GlobalManager _instance;
        public static GlobalManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<GlobalManager>();

                    if (_instance == null)
                    {
                        GameObject go = new GameObject("InputManager");
                        _instance = go.AddComponent<GlobalManager>();
                        DontDestroyOnLoad(go);
                    }
                }
                return _instance;
            }
        }

        // PRIVATE
        private void Awake()
        {
            // If the singleton hasn't been defined yet
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
            // If the singleton has another instance and it's not this one
            else if (_instance != this)
            {
                // Destroy the current game object, ensuring only one instance is kept
                Destroy(gameObject);
            }
        }

        // Add your input parsing methods and logic below
        private void Update()
        {
            // Example: Check for a specific key press
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key pressed");
            }
        }
    }
}
