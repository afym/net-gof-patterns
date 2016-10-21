using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwarePatterns.Behavioral.Memento;
using System.Collections.Generic;

namespace SoftwarePatternsTest.Behavioral
{
    [TestClass]
    public class Memento
    {
        [TestMethod]
        public void TestInstance()
        {
            Form Form = new Form();
            Assert.IsInstanceOfType(Form, typeof(Form));
        }

        [TestMethod]
        public void TestCloneObject() 
        {
            Form Form = new Form();
            Form.Name = "Name";
            Form.LastName = "Last";
            Form.Resume = "Resu";
            Form.Created = DateTime.Now;

            Form New = (Form)Form.Clone();
            New.Name = "Name2";

            Assert.AreEqual(Form.Name, "Name");
            Assert.AreEqual(New.Name, "Name2");
        }

        [TestMethod]
        public void TestMementoForm() 
        {
            Form Form = new Form();
            Form.Name = "Name";
            Form.LastName = "Last";
            Form.Resume = "Resu";
            Form.Created = DateTime.Now;

            Form New = MementoForm.GetNewForm(Form);
            New.Name = "Name3";

            Assert.AreEqual(Form.Name, "Name");
            Assert.AreEqual(New.Name, "Name3");
        }

        [TestMethod]
        public void TestMementoFormList() 
        {
            Dictionary<string, Form> Dictionary = new Dictionary<string, Form>();

            Dictionary.Add("N1", new Form() { Name = "Name1", LastName = "Last1"});
            Dictionary.Add("N2", new Form() { Name = "Name2", LastName = "Last2" });
            Dictionary.Add("N3", new Form() { Name = "Name3", LastName = "Last3" });

            Assert.AreEqual(Dictionary["N1"].Name, "Name1");

            Dictionary["N1"] = Dictionary["N2"];

            Assert.AreEqual(Dictionary["N1"].Name, "Name2");

            Form FormClone =  MementoForm.GetNewForm(Dictionary["N1"]);
            Dictionary["N1"] = FormClone;
            FormClone.Name = "Name55";

            Assert.AreEqual(FormClone.Name, "Name55");
        }


        [TestMethod]
        public void TestMemento() 
        {
            CareTakerForm CareTaker = new CareTakerForm();

            Form Form = new Form();
            Form.Name = "Roger";
            Form.LastName = "Marks";
            Form.Created = DateTime.Now;
            Form.Resume = "Software Developer";

            CareTaker.SetForm(Form);

            CareTaker.SaveMementoState("InitialForm");

            Form.Resume = "Software Architec";

            CareTaker.SaveMementoState("Correct2");

            Form.Name = "Roger Roger";

            CareTaker.SaveMementoState("Correct3");

            Assert.AreEqual(Form.Name, "Roger Roger");
            Assert.AreEqual(Form.Resume, "Software Architec");

            Form = CareTaker.RecoveryMementoState("InitialForm");

            Assert.AreEqual(Form.Name, "Roger");
            Assert.AreEqual(Form.Resume, "Software Developer");

            Form = CareTaker.RecoveryMementoState("Correct2");

            Assert.AreEqual(Form.Name, "Roger");
            Assert.AreEqual(Form.Resume, "Software Architec");
        }
    }
}