using System;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
    /// <summary>
    /// template class to create new editor
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EditorCustom<T> : Editor where T : MonoBehaviour
    {
        protected T eTarget = default(T); // editor target

        protected virtual void OnEnable()
        {
            eTarget = (T)target;
            eTarget.name = $"{ typeof(T).Name}";
        }
    }
}