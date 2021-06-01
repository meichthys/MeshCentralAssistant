﻿/*
Copyright 2009-2021 Intel Corporation

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Windows.Forms;

namespace MeshAssistant
{
    public partial class SnapShotForm : Form
    {
        public MainForm parent;

        public SnapShotForm(MainForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            Translate.TranslateControl(this);
            if (parent.agent != null) { parent.agent.QueryDescriptors(); }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void displaySnapShot(string data)
        {
            mainTextBox.Text = data;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (parent.agent != null) { parent.agent.QueryDescriptors(); }
        }

        private void SnapShotForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.snapShotForm = null;
        }
    }
}
