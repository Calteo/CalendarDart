﻿namespace Calendar.Dart
{
    partial class AskContinuePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskContinuePanel));
            this.SuspendLayout();
            // 
            // AskContinuePanel
            // 
            resources.ApplyResources(this, "$this");
            this.LeftText = "Ja";
            this.Message = "Soll das vorhandene Spiel fortgesetzt werden?";
            this.Name = "AskContinuePanel";
            this.RightText = "Nein";
            this.ResumeLayout(false);

        }

        #endregion
    }
}