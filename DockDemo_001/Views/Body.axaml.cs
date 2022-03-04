using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using NP.Avalonia.UniDock;
using System;

namespace DockDemo_001.Views
{
   
    public partial class Body : UserControl
    {
        public DockManager _dockManager;
        public Body()
        {
            InitializeComponent();
            _dockManager = (DockManager)this.FindResource("TheDockManager")!;
            _dockManager.RestoreFromFile("DefaultLayout.xml");

        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
