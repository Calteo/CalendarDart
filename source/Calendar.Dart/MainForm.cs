using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calendar.Dart
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormShown(object sender, EventArgs e)
        {
            NextPanel<TitlePanel>();
        }

        private Dictionary<Type, ThemedPanel> Panels { get; } = new Dictionary<Type, ThemedPanel>();
        
        private ThemedPanel GetPanel<T>() where T : ThemedPanel
        {
            if (!Panels.TryGetValue(typeof(T), out ThemedPanel panel))
            {
                panel = Panels[typeof(T)] = Activator.CreateInstance<T>();
                panel.Dock = DockStyle.Fill;
                panel.MainForm = this;                
            }
            return panel;
        }

        public void NextPanel<T>() where T : ThemedPanel
        {
            ShowPanel(GetPanel<T>());
        }

        public ThemedPanel CurrentPanel { get; set; }

        void ShowPanel(ThemedPanel panel)
        {
            if (CurrentPanel != null)
                Controls.Remove(CurrentPanel);
            Controls.Add(panel);
            panel.Activate();
            panel.BringToFront();
            panel.Play();
        }

        public Game Game { get; set; }   
    }
}