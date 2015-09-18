﻿using System.ComponentModel;
using System.Windows.Forms;
using Klocman.Controls;

namespace BulkCrapUninstaller.Controls
{
    partial class PropertiesSidebar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesSidebar));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxBatchSortQuiet = new System.Windows.Forms.CheckBox();
            this.checkBoxOrphans = new System.Windows.Forms.CheckBox();
            this.checkBoxInvalidTest = new System.Windows.Forms.CheckBox();
            this.checkBoxCertTest = new System.Windows.Forms.CheckBox();
            this.checkBoxDiisableProtection = new System.Windows.Forms.CheckBox();
            this.checkBoxSimulate = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxListHideMicrosoft = new System.Windows.Forms.CheckBox();
            this.checkBoxListSysComp = new System.Windows.Forms.CheckBox();
            this.checkBoxListProtected = new System.Windows.Forms.CheckBox();
            this.checkBoxShowUpdates = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxViewCheckboxes = new System.Windows.Forms.CheckBox();
            this.checkBoxViewGroups = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.usageTracker1 = new Klocman.Subsystems.Tracking.UsageTracker();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.flowLayoutPanel4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Controls.Add(this.checkBoxBatchSortQuiet);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxOrphans);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxInvalidTest);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxCertTest);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxDiisableProtection);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxSimulate);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.toolTip1.SetToolTip(this.flowLayoutPanel4, resources.GetString("flowLayoutPanel4.ToolTip"));
            // 
            // checkBoxBatchSortQuiet
            // 
            resources.ApplyResources(this.checkBoxBatchSortQuiet, "checkBoxBatchSortQuiet");
            this.checkBoxBatchSortQuiet.Name = "checkBoxBatchSortQuiet";
            this.toolTip1.SetToolTip(this.checkBoxBatchSortQuiet, resources.GetString("checkBoxBatchSortQuiet.ToolTip"));
            this.checkBoxBatchSortQuiet.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrphans
            // 
            resources.ApplyResources(this.checkBoxOrphans, "checkBoxOrphans");
            this.checkBoxOrphans.Name = "checkBoxOrphans";
            this.toolTip1.SetToolTip(this.checkBoxOrphans, resources.GetString("checkBoxOrphans.ToolTip"));
            this.checkBoxOrphans.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvalidTest
            // 
            resources.ApplyResources(this.checkBoxInvalidTest, "checkBoxInvalidTest");
            this.checkBoxInvalidTest.Name = "checkBoxInvalidTest";
            this.toolTip1.SetToolTip(this.checkBoxInvalidTest, resources.GetString("checkBoxInvalidTest.ToolTip"));
            this.checkBoxInvalidTest.UseVisualStyleBackColor = true;
            // 
            // checkBoxCertTest
            // 
            resources.ApplyResources(this.checkBoxCertTest, "checkBoxCertTest");
            this.checkBoxCertTest.Name = "checkBoxCertTest";
            this.toolTip1.SetToolTip(this.checkBoxCertTest, resources.GetString("checkBoxCertTest.ToolTip"));
            this.checkBoxCertTest.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiisableProtection
            // 
            resources.ApplyResources(this.checkBoxDiisableProtection, "checkBoxDiisableProtection");
            this.checkBoxDiisableProtection.Name = "checkBoxDiisableProtection";
            this.toolTip1.SetToolTip(this.checkBoxDiisableProtection, resources.GetString("checkBoxDiisableProtection.ToolTip"));
            this.checkBoxDiisableProtection.UseVisualStyleBackColor = true;
            // 
            // checkBoxSimulate
            // 
            resources.ApplyResources(this.checkBoxSimulate, "checkBoxSimulate");
            this.checkBoxSimulate.Name = "checkBoxSimulate";
            this.toolTip1.SetToolTip(this.checkBoxSimulate, resources.GetString("checkBoxSimulate.ToolTip"));
            this.checkBoxSimulate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.checkBoxListHideMicrosoft);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxListSysComp);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxListProtected);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxShowUpdates);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.toolTip1.SetToolTip(this.flowLayoutPanel2, resources.GetString("flowLayoutPanel2.ToolTip"));
            // 
            // checkBoxListHideMicrosoft
            // 
            resources.ApplyResources(this.checkBoxListHideMicrosoft, "checkBoxListHideMicrosoft");
            this.checkBoxListHideMicrosoft.Name = "checkBoxListHideMicrosoft";
            this.toolTip1.SetToolTip(this.checkBoxListHideMicrosoft, resources.GetString("checkBoxListHideMicrosoft.ToolTip"));
            this.checkBoxListHideMicrosoft.UseVisualStyleBackColor = true;
            // 
            // checkBoxListSysComp
            // 
            resources.ApplyResources(this.checkBoxListSysComp, "checkBoxListSysComp");
            this.checkBoxListSysComp.Name = "checkBoxListSysComp";
            this.toolTip1.SetToolTip(this.checkBoxListSysComp, resources.GetString("checkBoxListSysComp.ToolTip"));
            this.checkBoxListSysComp.UseVisualStyleBackColor = true;
            // 
            // checkBoxListProtected
            // 
            resources.ApplyResources(this.checkBoxListProtected, "checkBoxListProtected");
            this.checkBoxListProtected.Name = "checkBoxListProtected";
            this.toolTip1.SetToolTip(this.checkBoxListProtected, resources.GetString("checkBoxListProtected.ToolTip"));
            this.checkBoxListProtected.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowUpdates
            // 
            resources.ApplyResources(this.checkBoxShowUpdates, "checkBoxShowUpdates");
            this.checkBoxShowUpdates.Name = "checkBoxShowUpdates";
            this.toolTip1.SetToolTip(this.checkBoxShowUpdates, resources.GetString("checkBoxShowUpdates.ToolTip"));
            this.checkBoxShowUpdates.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.checkBoxViewCheckboxes);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxViewGroups);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // checkBoxViewCheckboxes
            // 
            resources.ApplyResources(this.checkBoxViewCheckboxes, "checkBoxViewCheckboxes");
            this.checkBoxViewCheckboxes.Name = "checkBoxViewCheckboxes";
            this.toolTip1.SetToolTip(this.checkBoxViewCheckboxes, resources.GetString("checkBoxViewCheckboxes.ToolTip"));
            this.checkBoxViewCheckboxes.UseVisualStyleBackColor = true;
            // 
            // checkBoxViewGroups
            // 
            resources.ApplyResources(this.checkBoxViewGroups, "checkBoxViewGroups");
            this.checkBoxViewGroups.Name = "checkBoxViewGroups";
            this.toolTip1.SetToolTip(this.checkBoxViewGroups, resources.GetString("checkBoxViewGroups.ToolTip"));
            this.checkBoxViewGroups.UseVisualStyleBackColor = true;
            // 
            // usageTracker1
            // 
            this.usageTracker1.ContainerControl = this;
            // 
            // PropertiesSidebar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PropertiesSidebar";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel4;
        private CheckBox checkBoxBatchSortQuiet;
        private CheckBox checkBoxDiisableProtection;
        private CheckBox checkBoxSimulate;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox checkBoxListHideMicrosoft;
        private CheckBox checkBoxShowUpdates;
        private CheckBox checkBoxListSysComp;
        private CheckBox checkBoxListProtected;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBoxViewCheckboxes;
        private CheckBox checkBoxViewGroups;
        private ToolTip toolTip1;
        private Klocman.Subsystems.Tracking.UsageTracker usageTracker1;
        private CheckBox checkBoxCertTest;
        private CheckBox checkBoxInvalidTest;
        private CheckBox checkBoxOrphans;
    }
}