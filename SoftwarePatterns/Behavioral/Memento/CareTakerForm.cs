using System;
using System.Collections.Generic;

namespace SoftwarePatterns.Behavioral.Memento
{
    public class CareTakerForm
    {
        private Dictionary<String, Form> FormList;
        private Form Form;

        public CareTakerForm() 
        {
            FormList = new Dictionary<String, Form>();
        }

        public void SetForm(Form Form) 
        {
            this.Form = Form;
        }

        public void SaveMementoState(string Key) 
        {
            FormList.Add(Key, MementoForm.GetNewForm(this.Form));
        }

        public Form RecoveryMementoState(string Key) 
        {
            return FormList[Key];
        }
    }
}
