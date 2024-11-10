using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MedicalPractitionerNamespace
{
    public class NurseFactory
    {
        public Nurse CreateNurse(string name)
        {
            Nurse newNurse = new GameObject(name).AddComponent<Nurse>();
            newNurse.sName = name;

            // You can set additional properties or initialize as needed
            return newNurse;
        }
    }
}
